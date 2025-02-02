using ApplicantAccounting.Models;
using ApplicantAccounting.Models.Controllers;
using ApplicantAccounting.ValueObjects;
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
        dataGridView1.Columns.Clear();
        dataGridView1.Rows.Clear();
        foreach (var column in Record.GetColumns())
        {
            dataGridView1.Columns.Add(column.Key, column.Value);
        }

        foreach (var record in RecordController.GetFiltered(GetPredicateForSelectedFilter()))
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

    private Func<Record, bool> GetPredicateForSelectedFilter()
    {
        var predicates = new Dictionary<RadioButton, Func<Record, bool>>()
        {
            { dormitoryRadio, record => record.Dormitory },
            { coursesRadio, record => record.Courses },
            { benefitsRadio, record => record.Benefits },
            { kiRado, record => record.SpecializationTypeId == SpecializationType.KI },
            { mtRadio, record => record.SpecializationTypeId == SpecializationType.MT },
            { mgRadio, record => record.SpecializationTypeId == SpecializationType.MG },
            { grsRadio, record => record.SpecializationTypeId == SpecializationType.GRS },
            { ptbRadio, record => record.SpecializationTypeId == SpecializationType.PTB },
            { fbRadio, record => record.SpecializationTypeId == SpecializationType.FB }
        };

        var predicate = predicates.FirstOrDefault(pair => pair.Key.Checked).Value ?? (_ => true);

        if (!lastNameInput.Text.IsNullOrEmpty())
        {
            var predicate1 = predicate;
            predicate = record => predicate1(record) && record.LastName == lastNameInput.Text;
        }

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
        catch (Exception)
        {
            MessageBox.Show("Такого запису не існує");
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
}