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
        cityRadio = new System.Windows.Forms.RadioButton();
        villageRadio = new System.Windows.Forms.RadioButton();
        label7 = new System.Windows.Forms.Label();
        regCertifInput = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        idCodeInput = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        passportInput = new System.Windows.Forms.TextBox();
        educationSelect = new System.Windows.Forms.ComboBox();
        label10 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dormitoryCheckbox = new System.Windows.Forms.CheckBox();
        benefitsCheckbox = new System.Windows.Forms.CheckBox();
        coursesCheckbox = new System.Windows.Forms.CheckBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
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
        button2.Location = new System.Drawing.Point(180, 492);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(121, 30);
        button2.TabIndex = 8;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // addressInput
        // 
        addressInput.Location = new System.Drawing.Point(119, 52);
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
        genderSelect.FormattingEnabled = true;
        genderSelect.Location = new System.Drawing.Point(119, 109);
        genderSelect.Name = "genderSelect";
        genderSelect.Size = new System.Drawing.Size(170, 23);
        genderSelect.TabIndex = 15;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(13, 55);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(58, 23);
        label4.TabIndex = 16;
        label4.Text = "Адреса";
        // 
        // cityRadio
        // 
        cityRadio.Location = new System.Drawing.Point(119, 22);
        cityRadio.Name = "cityRadio";
        cityRadio.Size = new System.Drawing.Size(74, 24);
        cityRadio.TabIndex = 17;
        cityRadio.TabStop = true;
        cityRadio.Text = "Місто";
        cityRadio.UseVisualStyleBackColor = true;
        // 
        // villageRadio
        // 
        villageRadio.Location = new System.Drawing.Point(215, 22);
        villageRadio.Name = "villageRadio";
        villageRadio.Size = new System.Drawing.Size(74, 24);
        villageRadio.TabIndex = 18;
        villageRadio.TabStop = true;
        villageRadio.Text = "Село";
        villageRadio.UseVisualStyleBackColor = true;
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
        educationSelect.FormattingEnabled = true;
        educationSelect.Location = new System.Drawing.Point(131, 418);
        educationSelect.Name = "educationSelect";
        educationSelect.Size = new System.Drawing.Size(170, 23);
        educationSelect.TabIndex = 26;
        educationSelect.ValueMember = "Key";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(25, 418);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 23);
        label10.TabIndex = 25;
        label10.Text = "Освіта";
        // 
        // groupBox1
        // 
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
        groupBox1.Size = new System.Drawing.Size(300, 141);
        groupBox1.TabIndex = 27;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(cityRadio);
        groupBox2.Controls.Add(villageRadio);
        groupBox2.Controls.Add(addressInput);
        groupBox2.Controls.Add(label4);
        groupBox2.Location = new System.Drawing.Point(12, 192);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(300, 91);
        groupBox2.TabIndex = 28;
        groupBox2.TabStop = false;
        groupBox2.Text = "Місце проживання";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(passportInput);
        groupBox3.Controls.Add(label9);
        groupBox3.Controls.Add(idCodeInput);
        groupBox3.Controls.Add(label8);
        groupBox3.Controls.Add(regCertifInput);
        groupBox3.Controls.Add(label7);
        groupBox3.Location = new System.Drawing.Point(12, 289);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(300, 115);
        groupBox3.TabIndex = 29;
        groupBox3.TabStop = false;
        groupBox3.Text = "Документи";
        // 
        // dormitoryCheckbox
        // 
        dormitoryCheckbox.Location = new System.Drawing.Point(25, 447);
        dormitoryCheckbox.Name = "dormitoryCheckbox";
        dormitoryCheckbox.Size = new System.Drawing.Size(104, 24);
        dormitoryCheckbox.TabIndex = 31;
        dormitoryCheckbox.Text = "Гуртожиток";
        dormitoryCheckbox.UseVisualStyleBackColor = true;
        // 
        // benefitsCheckbox
        // 
        benefitsCheckbox.Location = new System.Drawing.Point(149, 447);
        benefitsCheckbox.Name = "benefitsCheckbox";
        benefitsCheckbox.Size = new System.Drawing.Size(86, 24);
        benefitsCheckbox.TabIndex = 32;
        benefitsCheckbox.Text = "Пільги";
        benefitsCheckbox.UseVisualStyleBackColor = true;
        // 
        // coursesCheckbox
        // 
        coursesCheckbox.Location = new System.Drawing.Point(241, 447);
        coursesCheckbox.Name = "coursesCheckbox";
        coursesCheckbox.Size = new System.Drawing.Size(104, 24);
        coursesCheckbox.TabIndex = 33;
        coursesCheckbox.Text = "Курси";
        coursesCheckbox.UseVisualStyleBackColor = true;
        // 
        // CreateRecordForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(326, 536);
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
        ResumeLayout(false);
    }

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

    private System.Windows.Forms.RadioButton cityRadio;
    private System.Windows.Forms.RadioButton villageRadio;

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