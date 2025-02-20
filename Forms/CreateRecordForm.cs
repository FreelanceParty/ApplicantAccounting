using ApplicantAccounting.Models;
using ApplicantAccounting.Models.Factories;
using ApplicantAccounting.ValueObjects;

namespace ApplicantAccounting.Forms;

public partial class CreateRecordForm : Form
{
    private readonly Record? _record;

    public CreateRecordForm(Record? record = null)
    {
        _record = record;
        InitializeComponent();
        if (record != null)
        {
            Text = "Редагувати запис";
            button2.Text = "Редагувати";
        }

        FillSelectsWithValues();
        ChooseDefaultValues();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var checkedSpecializationRadio = specializationGroupBox.Controls
            .OfType<RadioButton>()
            .First(cb => cb.Checked);

        if (_record != null)
        {
            RecordFactory.Update(
                _record,
                lastNameInput.Text,
                firstNameInput.Text,
                middleNameInput.Text,
                DateTime.Parse(birthDatePicker.Text),
                genderSelect.SelectedIndex,
                localityInput.Text,
                addressInput.Text,
                passportInput.Text,
                idCodeInput.Text,
                regCertifInput.Text,
                educationSelect.SelectedIndex,
                dormitoryCheckbox.Checked,
                coursesCheckbox.Checked,
                benefitsCheckbox.Checked,
                int.Parse(checkedSpecializationRadio.Tag.ToString()),
                notesInput.Text
            );
        }
        else
        {
            RecordFactory.Create(
                lastNameInput.Text,
                firstNameInput.Text,
                middleNameInput.Text,
                DateTime.Parse(birthDatePicker.Text),
                genderSelect.SelectedIndex,
                localityInput.Text,
                addressInput.Text,
                passportInput.Text,
                idCodeInput.Text,
                regCertifInput.Text,
                educationSelect.SelectedIndex,
                dormitoryCheckbox.Checked,
                coursesCheckbox.Checked,
                benefitsCheckbox.Checked,
                int.Parse(checkedSpecializationRadio.Tag.ToString()),
                DateTime.Now,
                notesInput.Text
            );
        }

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

    private void ChooseDefaultValues()
    {
        if (_record == null)
        {
            genderSelect.SelectedIndex = 0;
            educationSelect.SelectedIndex = 0;
            kiRadio.Checked = true;
        }
        else
        {
            lastNameInput.Text = _record.LastName;
            firstNameInput.Text = _record.FirstName;
            middleNameInput.Text = _record.MiddleName;
            genderSelect.SelectedIndex = _record.GenderTypeId;

            localityInput.Text = _record.Locality;
            addressInput.Text = _record.Address;

            specializationGroupBox.Controls.OfType<RadioButton>()
                .First(rb => rb.Tag?.ToString() == _record.SpecializationTypeId.ToString())
                .Checked = true;
            educationSelect.SelectedIndex = _record.EducationTypeId;

            dormitoryCheckbox.Checked = _record.Dormitory;
            benefitsCheckbox.Checked = _record.Benefits;
            coursesCheckbox.Checked = _record.Courses;

            passportInput.Text = _record.PassportNumber;
            idCodeInput.Text = _record.IdCode;
            regCertifInput.Text = _record.RegistrationСertificate;
            notesInput.Text = _record.Notes;
        }
    }
}