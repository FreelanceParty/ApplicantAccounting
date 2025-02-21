using ApplicantAccounting.Models;
using ApplicantAccounting.Models.Controllers;
using ApplicantAccounting.ValueObjects;
using ApplicantAccounting.ValueObjects.Constants;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;

namespace ApplicantAccounting.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void newRecordButton_Click(object sender, EventArgs e)
    {
        CreateRecordForm form = new CreateRecordForm();
        form.Show();
    }

    private void showButton_Click(object sender, EventArgs e)
    {
        Show();
    }

    private Func<Record, bool> GetPredicateForSelectedFilter()
    {
        var predicates = new Dictionary<RadioButton, Func<Record, bool>>()
        {
            { dormitoryRadio, record => record.Dormitory },
            { coursesRadio, record => record.Courses },
            { benefitsRadio, record => record.Benefits },
            { kiRado, record => record.SpecializationTypeIds.Contains(SpecializationType.KI) },
            { mtRadio, record => record.SpecializationTypeIds.Contains(SpecializationType.MT) },
            { mgRadio, record => record.SpecializationTypeIds.Contains(SpecializationType.MG) },
            { grsRadio, record => record.SpecializationTypeIds.Contains(SpecializationType.GRS) },
            { ptbRadio, record => record.SpecializationTypeIds.Contains(SpecializationType.PTB) },
            { fbRadio, record => record.SpecializationTypeIds.Contains(SpecializationType.FB) },
        };

        var predicate = predicates.FirstOrDefault(pair => pair.Key.Checked).Value ?? (_ => true);

        if (!lastNameInput.Text.IsNullOrEmpty())
        {
            var predicate1 = predicate;
            predicate = record => predicate1(record) && record.LastName == lastNameInput.Text;
        }

        var predicate2 = predicate;
        predicate = record => predicate2(record) && record.SubmissionDate >= fromDatePicker.Value &&
                              record.SubmissionDate <= toDatePicker.Value;

        return predicate;
    }

    private void editRecordButton_Click(object sender, EventArgs e)
    {
        try
        {
            int id = (int)recordIdInput.Value;
            Record record = RecordController.FindById(id);
            CreateRecordForm form = new CreateRecordForm(record);
            form.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void excelButton_Click(object sender, EventArgs e)
    {
        try
        {
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Сторінка 1");
            for (int col = 0; col < dataGridView1.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
            }

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();
                }
            }

            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

            using SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Зберегти файл Excel";
            saveFileDialog.FileName = $"applicants_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                package.SaveAs(fi);
                MessageBox.Show("Дані успішно експортовано!");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show("Помилка під час вивантаження в Excel: " + exception.Message);
        }
    }

    private void statisticsSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool forToday = statisticsSelect.SelectedIndex == 0;
        countInput.Text = RecordController.GetCount(forToday).ToString();
        Show(forToday);
    }

    private void Show(bool forToday = false)
    {
        dataGridView1.Columns.Clear();
        dataGridView1.Rows.Clear();
        foreach (var column in Record.GetColumns())
        {
            dataGridView1.Columns.Add(column.Key, column.Value);
        }

        List<Record> records = forToday
            ? RecordController.GetFiltered(record => record.SubmissionDate.Date == DateTime.Today)
            : RecordController.GetFiltered(GetPredicateForSelectedFilter());

        foreach (var record in records)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            var index = 0;
            foreach (var data in record.GetDataForGridRow())
            {
                row.Cells[index].Value = data.Value;
                index++;
            }

            dataGridView1.Rows.Add(row);
        }
    }

    private void printButton_Click(object sender, EventArgs e)
    {
        var printer = new DataGridViewPrinter(dataGridView1);
        printer.Print();
    }
}