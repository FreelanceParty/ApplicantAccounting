namespace ApplicantAccounting.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        recordIdInput = new System.Windows.Forms.NumericUpDown();
        label9 = new System.Windows.Forms.Label();
        editRecordButton = new System.Windows.Forms.Button();
        newRecordButton = new System.Windows.Forms.Button();
        statisticsGroupBox = new System.Windows.Forms.GroupBox();
        excelButton = new System.Windows.Forms.Button();
        printButton = new System.Windows.Forms.Button();
        statisticsSelect = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        countInput = new System.Windows.Forms.TextBox();
        lastNameInput = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        fromDatePicker = new System.Windows.Forms.DateTimePicker();
        toDatePicker = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        showButton = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        filterGroupBox = new System.Windows.Forms.GroupBox();
        fbRadio = new System.Windows.Forms.RadioButton();
        ptbRadio = new System.Windows.Forms.RadioButton();
        grsRadio = new System.Windows.Forms.RadioButton();
        mgRadio = new System.Windows.Forms.RadioButton();
        mtRadio = new System.Windows.Forms.RadioButton();
        kiRado = new System.Windows.Forms.RadioButton();
        benefitsRadio = new System.Windows.Forms.RadioButton();
        dormitoryRadio = new System.Windows.Forms.RadioButton();
        coursesRadio = new System.Windows.Forms.RadioButton();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)recordIdInput).BeginInit();
        statisticsGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox3.SuspendLayout();
        filterGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(252, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(129, 23);
        label1.TabIndex = 0;
        label1.Text = "Абітурієнт ХКФК";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(recordIdInput);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(editRecordButton);
        groupBox1.Controls.Add(newRecordButton);
        groupBox1.Location = new System.Drawing.Point(12, 35);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(282, 115);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // recordIdInput
        // 
        recordIdInput.Location = new System.Drawing.Point(142, 42);
        recordIdInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        recordIdInput.Name = "recordIdInput";
        recordIdInput.Size = new System.Drawing.Size(111, 23);
        recordIdInput.TabIndex = 4;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(152, 19);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 20);
        label9.TabIndex = 3;
        label9.Text = "Номер запису:";
        // 
        // editRecordButton
        // 
        editRecordButton.Location = new System.Drawing.Point(141, 71);
        editRecordButton.Name = "editRecordButton";
        editRecordButton.Size = new System.Drawing.Size(112, 35);
        editRecordButton.TabIndex = 1;
        editRecordButton.Text = "Редагувати запис";
        editRecordButton.UseVisualStyleBackColor = true;
        editRecordButton.Click += editRecordButton_Click;
        // 
        // newRecordButton
        // 
        newRecordButton.Location = new System.Drawing.Point(23, 71);
        newRecordButton.Name = "newRecordButton";
        newRecordButton.Size = new System.Drawing.Size(112, 35);
        newRecordButton.TabIndex = 0;
        newRecordButton.Text = "Новий запис";
        newRecordButton.UseVisualStyleBackColor = true;
        newRecordButton.Click += newRecordButton_Click;
        // 
        // statisticsGroupBox
        // 
        statisticsGroupBox.Controls.Add(excelButton);
        statisticsGroupBox.Controls.Add(printButton);
        statisticsGroupBox.Controls.Add(statisticsSelect);
        statisticsGroupBox.Controls.Add(dataGridView1);
        statisticsGroupBox.Controls.Add(countInput);
        statisticsGroupBox.Location = new System.Drawing.Point(12, 361);
        statisticsGroupBox.Name = "statisticsGroupBox";
        statisticsGroupBox.Size = new System.Drawing.Size(604, 301);
        statisticsGroupBox.TabIndex = 2;
        statisticsGroupBox.TabStop = false;
        statisticsGroupBox.Text = "Статистика";
        // 
        // excelButton
        // 
        excelButton.Location = new System.Drawing.Point(442, 37);
        excelButton.Name = "excelButton";
        excelButton.Size = new System.Drawing.Size(75, 23);
        excelButton.TabIndex = 7;
        excelButton.Text = "Excel";
        excelButton.UseVisualStyleBackColor = true;
        excelButton.Click += excelButton_Click;
        // 
        // printButton
        // 
        printButton.Location = new System.Drawing.Point(523, 37);
        printButton.Name = "printButton";
        printButton.Size = new System.Drawing.Size(75, 23);
        printButton.TabIndex = 6;
        printButton.Text = "Друк";
        printButton.UseVisualStyleBackColor = true;
        // 
        // statisticsSelect
        // 
        statisticsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        statisticsSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        statisticsSelect.FormattingEnabled = true;
        statisticsSelect.Items.AddRange(new object[] { "Сьогодні", "Всього" });
        statisticsSelect.Location = new System.Drawing.Point(7, 38);
        statisticsSelect.Name = "statisticsSelect";
        statisticsSelect.Size = new System.Drawing.Size(139, 23);
        statisticsSelect.TabIndex = 5;
        statisticsSelect.SelectedIndexChanged += statisticsSelect_SelectedIndexChanged;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(6, 77);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(592, 218);
        dataGridView1.TabIndex = 4;
        // 
        // countInput
        // 
        countInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        countInput.Location = new System.Drawing.Point(152, 33);
        countInput.Name = "countInput";
        countInput.Size = new System.Drawing.Size(79, 29);
        countInput.TabIndex = 1;
        // 
        // lastNameInput
        // 
        lastNameInput.Location = new System.Drawing.Point(81, 33);
        lastNameInput.Name = "lastNameInput";
        lastNameInput.Size = new System.Drawing.Size(205, 23);
        lastNameInput.TabIndex = 0;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 36);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(73, 23);
        label2.TabIndex = 1;
        label2.Text = "Прізвище";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(fromDatePicker);
        groupBox3.Controls.Add(toDatePicker);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label5);
        groupBox3.Location = new System.Drawing.Point(6, 65);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(280, 127);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        groupBox3.Text = "Дата запису";
        // 
        // fromDatePicker
        // 
        fromDatePicker.Location = new System.Drawing.Point(63, 43);
        fromDatePicker.Name = "fromDatePicker";
        fromDatePicker.Size = new System.Drawing.Size(201, 23);
        fromDatePicker.TabIndex = 5;
        fromDatePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
        // 
        // toDatePicker
        // 
        toDatePicker.Location = new System.Drawing.Point(63, 81);
        toDatePicker.Name = "toDatePicker";
        toDatePicker.Size = new System.Drawing.Size(201, 23);
        toDatePicker.TabIndex = 6;
        toDatePicker.Value = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(15, 48);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(58, 23);
        label4.TabIndex = 3;
        label4.Text = "від";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(15, 85);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(101, 23);
        label5.TabIndex = 4;
        label5.Text = "до";
        // 
        // showButton
        // 
        showButton.Location = new System.Drawing.Point(513, 162);
        showButton.Name = "showButton";
        showButton.Size = new System.Drawing.Size(85, 25);
        showButton.TabIndex = 22;
        showButton.Text = "Показати";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += showButton_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(318, 36);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 23;
        label3.Text = "Спеціальність";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(318, 101);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 24;
        label6.Text = "Гуртожиток";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(318, 134);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 25;
        label7.Text = "Курси";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(318, 168);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 23);
        label8.TabIndex = 26;
        label8.Text = "Пільги";
        // 
        // filterGroupBox
        // 
        filterGroupBox.Controls.Add(fbRadio);
        filterGroupBox.Controls.Add(ptbRadio);
        filterGroupBox.Controls.Add(grsRadio);
        filterGroupBox.Controls.Add(mgRadio);
        filterGroupBox.Controls.Add(mtRadio);
        filterGroupBox.Controls.Add(kiRado);
        filterGroupBox.Controls.Add(benefitsRadio);
        filterGroupBox.Controls.Add(dormitoryRadio);
        filterGroupBox.Controls.Add(coursesRadio);
        filterGroupBox.Controls.Add(label8);
        filterGroupBox.Controls.Add(label7);
        filterGroupBox.Controls.Add(label6);
        filterGroupBox.Controls.Add(label3);
        filterGroupBox.Controls.Add(showButton);
        filterGroupBox.Controls.Add(groupBox3);
        filterGroupBox.Controls.Add(label2);
        filterGroupBox.Controls.Add(lastNameInput);
        filterGroupBox.Location = new System.Drawing.Point(12, 156);
        filterGroupBox.Name = "filterGroupBox";
        filterGroupBox.Size = new System.Drawing.Size(606, 199);
        filterGroupBox.TabIndex = 3;
        filterGroupBox.TabStop = false;
        filterGroupBox.Text = "Вибірка";
        // 
        // fbRadio
        // 
        fbRadio.Location = new System.Drawing.Point(542, 55);
        fbRadio.Name = "fbRadio";
        fbRadio.Size = new System.Drawing.Size(62, 24);
        fbRadio.TabIndex = 35;
        fbRadio.TabStop = true;
        fbRadio.Text = "ФБ";
        fbRadio.UseVisualStyleBackColor = true;
        // 
        // ptbRadio
        // 
        ptbRadio.Location = new System.Drawing.Point(474, 55);
        ptbRadio.Name = "ptbRadio";
        ptbRadio.Size = new System.Drawing.Size(62, 24);
        ptbRadio.TabIndex = 34;
        ptbRadio.TabStop = true;
        ptbRadio.Text = "ПТБ";
        ptbRadio.UseVisualStyleBackColor = true;
        // 
        // grsRadio
        // 
        grsRadio.Location = new System.Drawing.Point(407, 55);
        grsRadio.Name = "grsRadio";
        grsRadio.Size = new System.Drawing.Size(62, 24);
        grsRadio.TabIndex = 33;
        grsRadio.TabStop = true;
        grsRadio.Text = "ГРС";
        grsRadio.UseVisualStyleBackColor = true;
        // 
        // mgRadio
        // 
        mgRadio.Location = new System.Drawing.Point(542, 31);
        mgRadio.Name = "mgRadio";
        mgRadio.Size = new System.Drawing.Size(62, 24);
        mgRadio.TabIndex = 32;
        mgRadio.TabStop = true;
        mgRadio.Text = "МГ";
        mgRadio.UseVisualStyleBackColor = true;
        // 
        // mtRadio
        // 
        mtRadio.Location = new System.Drawing.Point(474, 31);
        mtRadio.Name = "mtRadio";
        mtRadio.Size = new System.Drawing.Size(62, 24);
        mtRadio.TabIndex = 31;
        mtRadio.TabStop = true;
        mtRadio.Text = "МТ";
        mtRadio.UseVisualStyleBackColor = true;
        // 
        // kiRado
        // 
        kiRado.Location = new System.Drawing.Point(407, 31);
        kiRado.Name = "kiRado";
        kiRado.Size = new System.Drawing.Size(62, 24);
        kiRado.TabIndex = 30;
        kiRado.TabStop = true;
        kiRado.Text = "КІ";
        kiRado.UseVisualStyleBackColor = true;
        // 
        // benefitsRadio
        // 
        benefitsRadio.Location = new System.Drawing.Point(407, 163);
        benefitsRadio.Name = "benefitsRadio";
        benefitsRadio.Size = new System.Drawing.Size(62, 24);
        benefitsRadio.TabIndex = 29;
        benefitsRadio.TabStop = true;
        benefitsRadio.Text = "Так";
        benefitsRadio.UseVisualStyleBackColor = true;
        // 
        // dormitoryRadio
        // 
        dormitoryRadio.Location = new System.Drawing.Point(404, 96);
        dormitoryRadio.Name = "dormitoryRadio";
        dormitoryRadio.Size = new System.Drawing.Size(62, 24);
        dormitoryRadio.TabIndex = 28;
        dormitoryRadio.TabStop = true;
        dormitoryRadio.Tag = "withDormitory";
        dormitoryRadio.Text = "Так";
        dormitoryRadio.UseVisualStyleBackColor = true;
        // 
        // coursesRadio
        // 
        coursesRadio.Location = new System.Drawing.Point(407, 129);
        coursesRadio.Name = "coursesRadio";
        coursesRadio.Size = new System.Drawing.Size(62, 24);
        coursesRadio.TabIndex = 27;
        coursesRadio.TabStop = true;
        coursesRadio.Text = "Так";
        coursesRadio.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(630, 671);
        Controls.Add(filterGroupBox);
        Controls.Add(statisticsGroupBox);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "Головна Форма";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)recordIdInput).EndInit();
        statisticsGroupBox.ResumeLayout(false);
        statisticsGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox3.ResumeLayout(false);
        filterGroupBox.ResumeLayout(false);
        filterGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button printButton;
    private System.Windows.Forms.Button excelButton;

    private System.Windows.Forms.NumericUpDown recordIdInput;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.RadioButton kiRado;
    private System.Windows.Forms.RadioButton mtRadio;
    private System.Windows.Forms.RadioButton mgRadio;
    private System.Windows.Forms.RadioButton grsRadio;
    private System.Windows.Forms.RadioButton ptbRadio;
    private System.Windows.Forms.RadioButton fbRadio;

    private System.Windows.Forms.RadioButton dormitoryRadio;

    private System.Windows.Forms.RadioButton benefitsRadio;

    private System.Windows.Forms.RadioButton coursesRadio;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button showButton;

    private System.Windows.Forms.TextBox lastNameInput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker fromDatePicker;
    private System.Windows.Forms.DateTimePicker toDatePicker;
    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.GroupBox filterGroupBox;

    private System.Windows.Forms.Button newRecordButton;
    private System.Windows.Forms.Button editRecordButton;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox statisticsGroupBox;
    private System.Windows.Forms.TextBox countInput;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox statisticsSelect;

    private System.Windows.Forms.Label label1;

    #endregion
}