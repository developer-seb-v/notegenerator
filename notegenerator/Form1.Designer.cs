namespace notegenerator
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateOfStudy = new DateTimePicker();
            label2 = new Label();
            ptNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ptDOB = new DateTimePicker();
            studyOrdered = new ComboBox();
            label5 = new Label();
            studyPerformed = new ComboBox();
            label6 = new Label();
            refMDtxtBox = new TextBox();
            label7 = new Label();
            AcquisitionNum = new TextBox();
            label8 = new Label();
            label9 = new Label();
            locationTextBox = new ComboBox();
            sleepTech = new TextBox();
            generateReportBtn = new Button();
            groupBox1 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label10 = new Label();
            generateReportSplitBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 160);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "Date of Study";
            // 
            // dateOfStudy
            // 
            dateOfStudy.Location = new Point(224, 153);
            dateOfStudy.Name = "dateOfStudy";
            dateOfStudy.Size = new Size(400, 39);
            dateOfStudy.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 212);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 2;
            label2.Text = "Patient Name";
            // 
            // ptNameTextBox
            // 
            ptNameTextBox.Location = new Point(223, 205);
            ptNameTextBox.Name = "ptNameTextBox";
            ptNameTextBox.Size = new Size(200, 39);
            ptNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 322);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 4;
            label3.Text = "Study Ordered";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 265);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 5;
            label4.Text = "Patient DOB";
            // 
            // ptDOB
            // 
            ptDOB.Location = new Point(224, 258);
            ptDOB.Name = "ptDOB";
            ptDOB.Size = new Size(400, 39);
            ptDOB.TabIndex = 4;
            // 
            // studyOrdered
            // 
            studyOrdered.FormattingEnabled = true;
            studyOrdered.Items.AddRange(new object[] { "NPSG", "SPLIT NIGHT ", "TITRATION" });
            studyOrdered.Location = new Point(226, 319);
            studyOrdered.Name = "studyOrdered";
            studyOrdered.Size = new Size(242, 40);
            studyOrdered.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 385);
            label5.Name = "label5";
            label5.Size = new Size(192, 32);
            label5.TabIndex = 8;
            label5.Text = "Study Performed";
            // 
            // studyPerformed
            // 
            studyPerformed.FormattingEnabled = true;
            studyPerformed.Items.AddRange(new object[] { "NPSG", "SPLIT NIGHT ", "TITRATION" });
            studyPerformed.Location = new Point(226, 377);
            studyPerformed.Name = "studyPerformed";
            studyPerformed.Size = new Size(242, 40);
            studyPerformed.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 495);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 10;
            label6.Text = "Ref MD";
            // 
            // refMDtxtBox
            // 
            refMDtxtBox.Location = new Point(226, 495);
            refMDtxtBox.Name = "refMDtxtBox";
            refMDtxtBox.Size = new Size(200, 39);
            refMDtxtBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 436);
            label7.Name = "label7";
            label7.Size = new Size(153, 32);
            label7.TabIndex = 12;
            label7.Text = "Acquisition #";
            // 
            // AcquisitionNum
            // 
            AcquisitionNum.Location = new Point(226, 436);
            AcquisitionNum.Name = "AcquisitionNum";
            AcquisitionNum.Size = new Size(200, 39);
            AcquisitionNum.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 565);
            label8.Name = "label8";
            label8.Size = new Size(129, 32);
            label8.TabIndex = 14;
            label8.Text = "Sleep Tech";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 103);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 15;
            label9.Text = "Location";
            // 
            // locationTextBox
            // 
            locationTextBox.FormattingEnabled = true;
            locationTextBox.Items.AddRange(new object[] { "Long Beach", "Torrance" });
            locationTextBox.Location = new Point(224, 100);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(242, 40);
            locationTextBox.TabIndex = 1;
            // 
            // sleepTech
            // 
            sleepTech.Location = new Point(227, 565);
            sleepTech.Name = "sleepTech";
            sleepTech.Size = new Size(200, 39);
            sleepTech.TabIndex = 9;
            // 
            // generateReportBtn
            // 
            generateReportBtn.Location = new Point(227, 672);
            generateReportBtn.Name = "generateReportBtn";
            generateReportBtn.Size = new Size(208, 51);
            generateReportBtn.TabIndex = 19;
            generateReportBtn.Text = "Generate Report";
            generateReportBtn.UseVisualStyleBackColor = true;
            generateReportBtn.Click += generateReportBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(681, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 200);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Symptoms";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(200, 124);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(159, 36);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(200, 82);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(159, 36);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(200, 38);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(159, 36);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(35, 124);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(159, 36);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(35, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(159, 36);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(687, 268);
            label10.Name = "label10";
            label10.Size = new Size(224, 32);
            label10.TabIndex = 21;
            label10.Text = "Check all that apply";
            // 
            // generateReportSplitBtn
            // 
            generateReportSplitBtn.Location = new Point(227, 672);
            generateReportSplitBtn.Name = "generateReportSplitBtn";
            generateReportSplitBtn.Size = new Size(208, 51);
            generateReportSplitBtn.TabIndex = 22;
            generateReportSplitBtn.Text = "Generate Report";
            generateReportSplitBtn.UseVisualStyleBackColor = true;
            generateReportSplitBtn.Click += generateReportSplitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 800);
            Controls.Add(generateReportSplitBtn);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(generateReportBtn);
            Controls.Add(sleepTech);
            Controls.Add(locationTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AcquisitionNum);
            Controls.Add(label7);
            Controls.Add(refMDtxtBox);
            Controls.Add(label6);
            Controls.Add(studyPerformed);
            Controls.Add(label5);
            Controls.Add(studyOrdered);
            Controls.Add(ptDOB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ptNameTextBox);
            Controls.Add(label2);
            Controls.Add(dateOfStudy);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Generate Report ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateOfStudy;
        private Label label2;
        private TextBox ptNameTextBox;
        private Label label3;
        private Label label4;
        private DateTimePicker ptDOB;
        private ComboBox studyOrdered;
        private Label label5;
        private ComboBox studyPerformed;
        private Label label6;
        private TextBox refMDtxtBox;
        private Label label7;
        private TextBox AcquisitionNum;
        private Label label8;
        private Label label9;
        private ComboBox locationTextBox;
        private TextBox sleepTech;
        private Button generateReportBtn;
        private GroupBox groupBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label10;
        private Button generateReportSplitBtn;
    }
}
