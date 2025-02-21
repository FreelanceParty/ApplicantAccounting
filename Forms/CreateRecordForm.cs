using ApplicantAccounting.Models;
using ApplicantAccounting.Models.Factories;
using ApplicantAccounting.ValueObjects.Constants;

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
        FillCheckboxesWithValues();
        ChooseDefaultValues();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var checkedSpecializations = specializationGroupBox.Controls
            .OfType<CheckBox>()
            .Where(cb => cb.Checked)
            .Select(cb => int.Parse(cb.Tag.ToString()))
            .ToArray();
        
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
                checkedSpecializations,
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
                checkedSpecializations,
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

    private void FillCheckboxesWithValues()
    {
        kiCheckbox.Tag = SpecializationType.KI;
        mtCheckbox.Tag = SpecializationType.MT;
        mgCheckbox.Tag = SpecializationType.MG;
        grsCheckbox.Tag = SpecializationType.GRS;
        ptbCheckbox.Tag = SpecializationType.PTB;
        fbCheckbox.Tag = SpecializationType.FB;
    }

    private void ChooseDefaultValues()
    {
        if (_record == null)
        {
            genderSelect.SelectedIndex = 0;
            educationSelect.SelectedIndex = 0;
        }
        else
        {
            lastNameInput.Text = _record.LastName;
            firstNameInput.Text = _record.FirstName;
            middleNameInput.Text = _record.MiddleName;
            genderSelect.SelectedIndex = _record.GenderTypeId;

            localityInput.Text = _record.Locality;
            addressInput.Text = _record.Address;

            specializationGroupBox.Controls.OfType<CheckBox>()
                                                .First(rb => _record.SpecializationTypeIds.Contains(int.Parse(rb.Tag.ToString())))
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