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
}