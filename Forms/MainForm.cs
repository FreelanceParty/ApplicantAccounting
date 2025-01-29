using ApplicantAccounting.Models;
using ApplicantAccounting.Models.Controllers;

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
        foreach (var column in Record.GetColumns())
        {
            dataGridView1.Columns.Add(column.Key, column.Value);
        }

        foreach (var record in RecordController.GetAll())
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
}