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
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lastNameInput
        // 
        lastNameInput.Location = new System.Drawing.Point(118, 81);
        lastNameInput.Name = "lastNameInput";
        lastNameInput.Size = new System.Drawing.Size(100, 23);
        lastNameInput.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 84);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "Прізвище";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 113);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 3;
        label2.Text = "Ім\'я";
        // 
        // firstNameInput
        // 
        firstNameInput.Location = new System.Drawing.Point(118, 110);
        firstNameInput.Name = "firstNameInput";
        firstNameInput.Size = new System.Drawing.Size(100, 23);
        firstNameInput.TabIndex = 2;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 142);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 5;
        label3.Text = "По-батькові";
        // 
        // middleNameInput
        // 
        middleNameInput.Location = new System.Drawing.Point(118, 139);
        middleNameInput.Name = "middleNameInput";
        middleNameInput.Size = new System.Drawing.Size(100, 23);
        middleNameInput.TabIndex = 4;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new System.Drawing.Point(333, 81);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(455, 357);
        richTextBox1.TabIndex = 6;
        richTextBox1.Text = "";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(333, 45);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(121, 30);
        button1.TabIndex = 7;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(97, 188);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(121, 30);
        button2.TabIndex = 8;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // CreateRecordForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(richTextBox1);
        Controls.Add(label3);
        Controls.Add(middleNameInput);
        Controls.Add(label2);
        Controls.Add(firstNameInput);
        Controls.Add(label1);
        Controls.Add(lastNameInput);
        Text = "CreateRecord";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox lastNameInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox firstNameInput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox middleNameInput;
    private System.Windows.Forms.RichTextBox richTextBox1;

    #endregion
}