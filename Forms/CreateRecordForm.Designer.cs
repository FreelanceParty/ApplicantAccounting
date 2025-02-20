using System.ComponentModel;

namespace ApplicantAccounting.Forms;

partial class CreateRecordForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lastNameInput = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        firstNameInput = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        middleNameInput = new System.Windows.Forms.TextBox();
        button2 = new System.Windows.Forms.Button();
        addressInput = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        genderSelect = new System.Windows.Forms.ComboBox();
        label4 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        regCertifInput = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        idCodeInput = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        passportInput = new System.Windows.Forms.TextBox();
        educationSelect = new System.Windows.Forms.ComboBox();
        label10 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        birthDatePicker = new System.Windows.Forms.DateTimePicker();
        label11 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        localityInput = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dormitoryCheckbox = new System.Windows.Forms.CheckBox();
        benefitsCheckbox = new System.Windows.Forms.CheckBox();
        coursesCheckbox = new System.Windows.Forms.CheckBox();
        specializationGroupBox = new System.Windows.Forms.GroupBox();
        fbRadio = new System.Windows.Forms.RadioButton();
        ptbRadio = new System.Windows.Forms.RadioButton();
        grsRadio = new System.Windows.Forms.RadioButton();
        mgRadio = new System.Windows.Forms.RadioButton();
        mtRadio = new System.Windows.Forms.RadioButton();
        kiRadio = new System.Windows.Forms.RadioButton();
        notesInput = new System.Windows.Forms.TextBox();
        label12 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        specializationGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // lastNameInput
        // 
        lastNameInput.Location = new System.Drawing.Point(119, 22);
        lastNameInput.Name = "lastNameInput";
        lastNameInput.Size = new System.Drawing.Size(170, 23);
        lastNameInput.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(13, 25);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "Прізвище";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(13, 54);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 3;
        label2.Text = "Ім\'я";
        // 
        // firstNameInput
        // 
        firstNameInput.Location = new System.Drawing.Point(119, 51);
        firstNameInput.Name = "firstNameInput";
        firstNameInput.Size = new System.Drawing.Size(170, 23);
        firstNameInput.TabIndex = 2;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(13, 83);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 5;
        label3.Text = "По-батькові";
        // 
        // middleNameInput
        // 
        middleNameInput.Location = new System.Drawing.Point(119, 80);
        middleNameInput.Name = "middleNameInput";
        middleNameInput.Size = new System.Drawing.Size(170, 23);
        middleNameInput.TabIndex = 4;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(486, 322);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(121, 30);
        button2.TabIndex = 8;
        button2.Text = "Додати";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // addressInput
        // 
        addressInput.Location = new System.Drawing.Point(119, 59);
        addressInput.Name = "addressInput";
        addressInput.Size = new System.Drawing.Size(170, 23);
        addressInput.TabIndex = 11;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(13, 112);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 10;
        label6.Text = "Стать";
        // 
        // genderSelect
        // 
        genderSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        genderSelect.FormattingEnabled = true;
        genderSelect.Location = new System.Drawing.Point(119, 109);
        genderSelect.Name = "genderSelect";
        genderSelect.Size = new System.Drawing.Size(170, 23);
        genderSelect.TabIndex = 15;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(13, 62);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(58, 23);
        label4.TabIndex = 16;
        label4.Text = "Адреса";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(13, 83);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 24;
        label7.Text = "Приписне";
        // 
        // regCertifInput
        // 
        regCertifInput.Location = new System.Drawing.Point(119, 80);
        regCertifInput.Name = "regCertifInput";
        regCertifInput.Size = new System.Drawing.Size(170, 23);
        regCertifInput.TabIndex = 23;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(13, 54);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 23);
        label8.TabIndex = 22;
        label8.Text = "ІД код";
        // 
        // idCodeInput
        // 
        idCodeInput.Location = new System.Drawing.Point(119, 51);
        idCodeInput.Name = "idCodeInput";
        idCodeInput.Size = new System.Drawing.Size(170, 23);
        idCodeInput.TabIndex = 21;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(13, 25);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 23);
        label9.TabIndex = 20;
        label9.Text = "Паспорт №";
        // 
        // passportInput
        // 
        passportInput.Location = new System.Drawing.Point(119, 22);
        passportInput.Name = "passportInput";
        passportInput.Size = new System.Drawing.Size(170, 23);
        passportInput.TabIndex = 19;
        // 
        // educationSelect
        // 
        educationSelect.DisplayMember = "Value";
        educationSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        educationSelect.FormattingEnabled = true;
        educationSelect.Location = new System.Drawing.Point(437, 231);
        educationSelect.Name = "educationSelect";
        educationSelect.Size = new System.Drawing.Size(170, 23);
        educationSelect.TabIndex = 26;
        educationSelect.ValueMember = "Key";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(331, 234);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 23);
        label10.TabIndex = 25;
        label10.Text = "Освіта";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(birthDatePicker);
        groupBox1.Controls.Add(label11);
        groupBox1.Controls.Add(lastNameInput);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(firstNameInput);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(middleNameInput);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(genderSelect);
        groupBox1.Location = new System.Drawing.Point(12, 45);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(300, 180);
        groupBox1.TabIndex = 27;
        groupBox1.TabStop = false;
        groupBox1.Text = "Основна інформація";
        // 
        // birthDatePicker
        // 
        birthDatePicker.Location = new System.Drawing.Point(119, 138);
        birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
        birthDatePicker.Name = "birthDatePicker";
        birthDatePicker.Size = new System.Drawing.Size(170, 23);
        birthDatePicker.TabIndex = 17;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(13, 144);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(100, 23);
        label11.TabIndex = 16;
        label11.Text = "Дата народження";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(localityInput);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(addressInput);
        groupBox2.Controls.Add(label4);
        groupBox2.Location = new System.Drawing.Point(318, 45);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(300, 91);
        groupBox2.TabIndex = 28;
        groupBox2.TabStop = false;
        groupBox2.Text = "Місце проживання";
        // 
        // localityInput
        // 
        localityInput.Location = new System.Drawing.Point(119, 30);
        localityInput.Name = "localityInput";
        localityInput.Size = new System.Drawing.Size(170, 23);
        localityInput.TabIndex = 17;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(13, 33);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(104, 23);
        label5.TabIndex = 18;
        label5.Text = "Населений пункт";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(passportInput);
        groupBox3.Controls.Add(label9);
        groupBox3.Controls.Add(idCodeInput);
        groupBox3.Controls.Add(label8);
        groupBox3.Controls.Add(regCertifInput);
        groupBox3.Controls.Add(label7);
        groupBox3.Location = new System.Drawing.Point(12, 231);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(300, 115);
        groupBox3.TabIndex = 29;
        groupBox3.TabStop = false;
        groupBox3.Text = "Документи";
        // 
        // dormitoryCheckbox
        // 
        dormitoryCheckbox.Location = new System.Drawing.Point(331, 266);
        dormitoryCheckbox.Name = "dormitoryCheckbox";
        dormitoryCheckbox.Size = new System.Drawing.Size(104, 24);
        dormitoryCheckbox.TabIndex = 31;
        dormitoryCheckbox.Text = "Гуртожиток";
        dormitoryCheckbox.UseVisualStyleBackColor = true;
        // 
        // benefitsCheckbox
        // 
        benefitsCheckbox.Location = new System.Drawing.Point(437, 266);
        benefitsCheckbox.Name = "benefitsCheckbox";
        benefitsCheckbox.Size = new System.Drawing.Size(86, 24);
        benefitsCheckbox.TabIndex = 32;
        benefitsCheckbox.Text = "Пільги";
        benefitsCheckbox.UseVisualStyleBackColor = true;
        // 
        // coursesCheckbox
        // 
        coursesCheckbox.Location = new System.Drawing.Point(533, 266);
        coursesCheckbox.Name = "coursesCheckbox";
        coursesCheckbox.Size = new System.Drawing.Size(104, 24);
        coursesCheckbox.TabIndex = 33;
        coursesCheckbox.Text = "Курси";
        coursesCheckbox.UseVisualStyleBackColor = true;
        // 
        // specializationGroupBox
        // 
        specializationGroupBox.Controls.Add(fbRadio);
        specializationGroupBox.Controls.Add(ptbRadio);
        specializationGroupBox.Controls.Add(grsRadio);
        specializationGroupBox.Controls.Add(mgRadio);
        specializationGroupBox.Controls.Add(mtRadio);
        specializationGroupBox.Controls.Add(kiRadio);
        specializationGroupBox.Location = new System.Drawing.Point(320, 142);
        specializationGroupBox.Name = "specializationGroupBox";
        specializationGroupBox.Size = new System.Drawing.Size(298, 83);
        specializationGroupBox.TabIndex = 34;
        specializationGroupBox.TabStop = false;
        specializationGroupBox.Text = "Спеціальність";
        // 
        // fbRadio
        // 
        fbRadio.Location = new System.Drawing.Point(210, 52);
        fbRadio.Name = "fbRadio";
        fbRadio.Size = new System.Drawing.Size(77, 24);
        fbRadio.TabIndex = 5;
        fbRadio.TabStop = true;
        fbRadio.Tag = "5";
        fbRadio.Text = "ФБ";
        fbRadio.UseVisualStyleBackColor = true;
        // 
        // ptbRadio
        // 
        ptbRadio.Location = new System.Drawing.Point(114, 52);
        ptbRadio.Name = "ptbRadio";
        ptbRadio.Size = new System.Drawing.Size(77, 24);
        ptbRadio.TabIndex = 4;
        ptbRadio.TabStop = true;
        ptbRadio.Tag = "4";
        ptbRadio.Text = "ПТБ";
        ptbRadio.UseVisualStyleBackColor = true;
        // 
        // grsRadio
        // 
        grsRadio.Location = new System.Drawing.Point(11, 52);
        grsRadio.Name = "grsRadio";
        grsRadio.Size = new System.Drawing.Size(77, 24);
        grsRadio.TabIndex = 3;
        grsRadio.TabStop = true;
        grsRadio.Tag = "3";
        grsRadio.Text = "ГРС";
        grsRadio.UseVisualStyleBackColor = true;
        // 
        // mgRadio
        // 
        mgRadio.Location = new System.Drawing.Point(210, 22);
        mgRadio.Name = "mgRadio";
        mgRadio.Size = new System.Drawing.Size(77, 24);
        mgRadio.TabIndex = 2;
        mgRadio.TabStop = true;
        mgRadio.Tag = "2";
        mgRadio.Text = "МГ";
        mgRadio.UseVisualStyleBackColor = true;
        // 
        // mtRadio
        // 
        mtRadio.Location = new System.Drawing.Point(114, 22);
        mtRadio.Name = "mtRadio";
        mtRadio.Size = new System.Drawing.Size(77, 24);
        mtRadio.TabIndex = 1;
        mtRadio.TabStop = true;
        mtRadio.Tag = "1";
        mtRadio.Text = "МТ";
        mtRadio.UseVisualStyleBackColor = true;
        // 
        // kiRadio
        // 
        kiRadio.Location = new System.Drawing.Point(11, 22);
        kiRadio.Name = "kiRadio";
        kiRadio.Size = new System.Drawing.Size(77, 24);
        kiRadio.TabIndex = 0;
        kiRadio.TabStop = true;
        kiRadio.Tag = "0";
        kiRadio.Text = "КІ";
        kiRadio.UseVisualStyleBackColor = true;
        // 
        // notesInput
        // 
        notesInput.Location = new System.Drawing.Point(131, 349);
        notesInput.Name = "notesInput";
        notesInput.Size = new System.Drawing.Size(170, 23);
        notesInput.TabIndex = 35;
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(25, 352);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(100, 23);
        label12.TabIndex = 36;
        label12.Text = "Примітки";
        // 
        // CreateRecordForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(628, 384);
        Controls.Add(label12);
        Controls.Add(notesInput);
        Controls.Add(specializationGroupBox);
        Controls.Add(coursesCheckbox);
        Controls.Add(benefitsCheckbox);
        Controls.Add(dormitoryCheckbox);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(educationSelect);
        Controls.Add(button2);
        Controls.Add(label10);
        Text = "CreateRecord";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        specializationGroupBox.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.TextBox notesInput;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.DateTimePicker birthDatePicker;

    private System.Windows.Forms.TextBox localityInput;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.GroupBox specializationGroupBox;
    private System.Windows.Forms.RadioButton kiRadio;
    private System.Windows.Forms.RadioButton mtRadio;
    private System.Windows.Forms.RadioButton mgRadio;
    private System.Windows.Forms.RadioButton fbRadio;
    private System.Windows.Forms.RadioButton ptbRadio;
    private System.Windows.Forms.RadioButton grsRadio;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox dormitoryCheckbox;
    private System.Windows.Forms.CheckBox benefitsCheckbox;
    private System.Windows.Forms.CheckBox coursesCheckbox;

    private System.Windows.Forms.ComboBox educationSelect;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox regCertifInput;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox idCodeInput;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox passportInput;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox addressInput;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox genderSelect;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox lastNameInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox firstNameInput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox middleNameInput;

    #endregion
}