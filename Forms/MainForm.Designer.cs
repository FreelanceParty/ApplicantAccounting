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
        editRecordButton = new System.Windows.Forms.Button();
        newRecordButton = new System.Windows.Forms.Button();
        statisticsGroupBox = new System.Windows.Forms.GroupBox();
        comboBox1 = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        textBox1 = new System.Windows.Forms.TextBox();
        lastNameInput = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        showButton = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
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
        statisticsGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
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
        groupBox1.Controls.Add(editRecordButton);
        groupBox1.Controls.Add(newRecordButton);
        groupBox1.Location = new System.Drawing.Point(31, 47);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(282, 152);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // editRecordButton
        // 
        editRecordButton.Location = new System.Drawing.Point(45, 91);
        editRecordButton.Name = "editRecordButton";
        editRecordButton.Size = new System.Drawing.Size(163, 35);
        editRecordButton.TabIndex = 1;
        editRecordButton.Text = "Редагувати запис";
        editRecordButton.UseVisualStyleBackColor = true;
        // 
        // newRecordButton
        // 
        newRecordButton.Location = new System.Drawing.Point(45, 51);
        newRecordButton.Name = "newRecordButton";
        newRecordButton.Size = new System.Drawing.Size(163, 35);
        newRecordButton.TabIndex = 0;
        newRecordButton.Text = "Новий запис";
        newRecordButton.UseVisualStyleBackColor = true;
        newRecordButton.Click += newRecordButton_Click;
        // 
        // statisticsGroupBox
        // 
        statisticsGroupBox.Controls.Add(comboBox1);
        statisticsGroupBox.Controls.Add(dataGridView1);
        statisticsGroupBox.Controls.Add(textBox1);
        statisticsGroupBox.Location = new System.Drawing.Point(31, 205);
        statisticsGroupBox.Name = "statisticsGroupBox";
        statisticsGroupBox.Size = new System.Drawing.Size(282, 219);
        statisticsGroupBox.TabIndex = 2;
        statisticsGroupBox.TabStop = false;
        statisticsGroupBox.Text = "Статистика";
        // 
        // comboBox1
        // 
        comboBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Сьогодні", "Всього" });
        comboBox1.Location = new System.Drawing.Point(6, 27);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(139, 36);
        comboBox1.TabIndex = 5;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(6, 77);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(270, 136);
        dataGridView1.TabIndex = 4;
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
        textBox1.Location = new System.Drawing.Point(152, 27);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(123, 34);
        textBox1.TabIndex = 1;
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
        groupBox3.Controls.Add(dateTimePicker1);
        groupBox3.Controls.Add(dateTimePicker2);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label5);
        groupBox3.Location = new System.Drawing.Point(6, 65);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(280, 127);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        groupBox3.Text = "Дата запису";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new System.Drawing.Point(63, 43);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(201, 23);
        dateTimePicker1.TabIndex = 5;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new System.Drawing.Point(63, 81);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new System.Drawing.Size(201, 23);
        dateTimePicker2.TabIndex = 6;
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
        showButton.Location = new System.Drawing.Point(201, 342);
        showButton.Name = "showButton";
        showButton.Size = new System.Drawing.Size(85, 25);
        showButton.TabIndex = 22;
        showButton.Text = "Показати";
        showButton.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 216);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 23;
        label3.Text = "Спеціальність";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 281);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 24;
        label6.Text = "Гуртожиток";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(6, 314);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 25;
        label7.Text = "Курси";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(6, 348);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 23);
        label8.TabIndex = 26;
        label8.Text = "Пільги";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(fbRadio);
        groupBox2.Controls.Add(ptbRadio);
        groupBox2.Controls.Add(grsRadio);
        groupBox2.Controls.Add(mgRadio);
        groupBox2.Controls.Add(mtRadio);
        groupBox2.Controls.Add(kiRado);
        groupBox2.Controls.Add(benefitsRadio);
        groupBox2.Controls.Add(dormitoryRadio);
        groupBox2.Controls.Add(coursesRadio);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(showButton);
        groupBox2.Controls.Add(groupBox3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(lastNameInput);
        groupBox2.Location = new System.Drawing.Point(320, 47);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(298, 377);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "Вибірка";
        // 
        // fbRadio
        // 
        fbRadio.Location = new System.Drawing.Point(230, 235);
        fbRadio.Name = "fbRadio";
        fbRadio.Size = new System.Drawing.Size(62, 24);
        fbRadio.TabIndex = 35;
        fbRadio.TabStop = true;
        fbRadio.Text = "ФБ";
        fbRadio.UseVisualStyleBackColor = true;
        // 
        // ptbRadio
        // 
        ptbRadio.Location = new System.Drawing.Point(162, 235);
        ptbRadio.Name = "ptbRadio";
        ptbRadio.Size = new System.Drawing.Size(62, 24);
        ptbRadio.TabIndex = 34;
        ptbRadio.TabStop = true;
        ptbRadio.Text = "ПТБ";
        ptbRadio.UseVisualStyleBackColor = true;
        // 
        // grsRadio
        // 
        grsRadio.Location = new System.Drawing.Point(95, 235);
        grsRadio.Name = "grsRadio";
        grsRadio.Size = new System.Drawing.Size(62, 24);
        grsRadio.TabIndex = 33;
        grsRadio.TabStop = true;
        grsRadio.Text = "ГРС";
        grsRadio.UseVisualStyleBackColor = true;
        // 
        // mgRadio
        // 
        mgRadio.Location = new System.Drawing.Point(230, 211);
        mgRadio.Name = "mgRadio";
        mgRadio.Size = new System.Drawing.Size(62, 24);
        mgRadio.TabIndex = 32;
        mgRadio.TabStop = true;
        mgRadio.Text = "МГ";
        mgRadio.UseVisualStyleBackColor = true;
        // 
        // mtRadio
        // 
        mtRadio.Location = new System.Drawing.Point(162, 211);
        mtRadio.Name = "mtRadio";
        mtRadio.Size = new System.Drawing.Size(62, 24);
        mtRadio.TabIndex = 31;
        mtRadio.TabStop = true;
        mtRadio.Text = "МТ";
        mtRadio.UseVisualStyleBackColor = true;
        // 
        // kiRado
        // 
        kiRado.Location = new System.Drawing.Point(95, 211);
        kiRado.Name = "kiRado";
        kiRado.Size = new System.Drawing.Size(62, 24);
        kiRado.TabIndex = 30;
        kiRado.TabStop = true;
        kiRado.Text = "КІ";
        kiRado.UseVisualStyleBackColor = true;
        // 
        // benefitsRadio
        // 
        benefitsRadio.Location = new System.Drawing.Point(95, 343);
        benefitsRadio.Name = "benefitsRadio";
        benefitsRadio.Size = new System.Drawing.Size(62, 24);
        benefitsRadio.TabIndex = 29;
        benefitsRadio.TabStop = true;
        benefitsRadio.Text = "Так";
        benefitsRadio.UseVisualStyleBackColor = true;
        // 
        // dormitoryRadio
        // 
        dormitoryRadio.Location = new System.Drawing.Point(92, 276);
        dormitoryRadio.Name = "dormitoryRadio";
        dormitoryRadio.Size = new System.Drawing.Size(62, 24);
        dormitoryRadio.TabIndex = 28;
        dormitoryRadio.TabStop = true;
        dormitoryRadio.Text = "Так";
        dormitoryRadio.UseVisualStyleBackColor = true;
        // 
        // coursesRadio
        // 
        coursesRadio.Location = new System.Drawing.Point(95, 309);
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
        ClientSize = new System.Drawing.Size(652, 451);
        Controls.Add(groupBox2);
        Controls.Add(statisticsGroupBox);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "Головна Форма";
        groupBox1.ResumeLayout(false);
        statisticsGroupBox.ResumeLayout(false);
        statisticsGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

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
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.Button newRecordButton;
    private System.Windows.Forms.Button editRecordButton;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox statisticsGroupBox;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}