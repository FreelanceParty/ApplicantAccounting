using ApplicantAccounting.Models.Controllers;
using ApplicantAccounting.Models.Factories;
using ApplicantAccounting.ValueObjects;

namespace ApplicantAccounting.Forms;

public partial class CreateRecordForm : Form
{
    public CreateRecordForm()
    {
        InitializeComponent();
        FillSelectsWithValues();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var localityTypeId = cityRadio.Checked ? LocalityType.City : LocalityType.Village;
        RecordFactory.Create(
            lastNameInput.Text,
            firstNameInput.Text,
            middleNameInput.Text,
            genderSelect.SelectedIndex,
            localityTypeId,
            addressInput.Text,
            passportInput.Text,
            idCodeInput.Text,
            regCertifInput.Text,
            educationSelect.SelectedIndex,
            dormitoryCheckbox.Checked,
            coursesCheckbox.Checked,
            benefitsCheckbox.Checked
        );
        MessageBox.Show("Успіх");
    }

    private void FillSelectsWithValues()
    {
        foreach (var gType in GenderType.GetAll())
        {
            genderSelect.Items.Add(gType);
        }

        foreach (var edType in EducationType.GetAll())
        {
            educationSelect.Items.Add(edType);
        }

        educationSelect.DisplayMember = "Value";
        educationSelect.ValueMember = "Key";
        genderSelect.DisplayMember = "Value";
        genderSelect.ValueMember = "Key";
    }
}