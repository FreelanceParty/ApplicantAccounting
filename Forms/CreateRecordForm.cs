using ApplicantAccounting.Models.Controllers;
using ApplicantAccounting.Models.Factories;

namespace ApplicantAccounting.Forms;

public partial class CreateRecordForm : Form
{
    public CreateRecordForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var records = RecordController.GetAll();
        foreach (var record in records)
        {
            richTextBox1.Text += record.LastName;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        RecordFactory.Create(lastNameInput.Text, firstNameInput.Text, middleNameInput.Text);
    }
}