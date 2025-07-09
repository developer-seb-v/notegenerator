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
            locationCombo = new ComboBox();
            sleepTech = new TextBox();
            generateReportBtn = new Button();
            generateReportSplitBtn = new Button();
            label11 = new Label();
            ptIdBox = new TextBox();
            label12 = new Label();
            maskComboBox = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label15 = new Label();
            roomCombo = new ComboBox();
            commentBox = new TextBox();
            label16 = new Label();
            textBox3 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "Date of Study";
            // 
            // dateOfStudy
            // 
            dateOfStudy.Format = DateTimePickerFormat.Short;
            dateOfStudy.Location = new Point(258, 27);
            dateOfStudy.Name = "dateOfStudy";
            dateOfStudy.Size = new Size(400, 39);
            dateOfStudy.TabIndex = 2;
            dateOfStudy.ValueChanged += dateOfStudy_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 277);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 2;
            label2.Text = "Patient Name";
            // 
            // ptNameTextBox
            // 
            ptNameTextBox.Location = new Point(243, 286);
            ptNameTextBox.Name = "ptNameTextBox";
            ptNameTextBox.Size = new Size(398, 39);
            ptNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(703, 347);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 4;
            label3.Text = "Test Ordered";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 338);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 5;
            label4.Text = "Patient DOB";
            // 
            // ptDOB
            // 
            ptDOB.Location = new Point(243, 341);
            ptDOB.Name = "ptDOB";
            ptDOB.Size = new Size(400, 39);
            ptDOB.TabIndex = 4;
            // 
            // studyOrdered
            // 
            studyOrdered.FormattingEnabled = true;
            studyOrdered.Items.AddRange(new object[] { "NPSG", "SPLIT NIGHT ", "TITRATION" });
            studyOrdered.Location = new Point(901, 347);
            studyOrdered.Name = "studyOrdered";
            studyOrdered.Size = new Size(242, 40);
            studyOrdered.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(702, 410);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 8;
            label5.Text = "Test Conducted";
            // 
            // studyPerformed
            // 
            studyPerformed.FormattingEnabled = true;
            studyPerformed.Items.AddRange(new object[] { "NPSG", "SPLIT NIGHT ", "TITRATION" });
            studyPerformed.Location = new Point(901, 406);
            studyPerformed.Name = "studyPerformed";
            studyPerformed.Size = new Size(242, 40);
            studyPerformed.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(705, 289);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 10;
            label6.Text = "Ordering MD";
            // 
            // refMDtxtBox
            // 
            refMDtxtBox.Location = new Point(901, 292);
            refMDtxtBox.Name = "refMDtxtBox";
            refMDtxtBox.Size = new Size(200, 39);
            refMDtxtBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(706, 29);
            label7.Name = "label7";
            label7.Size = new Size(153, 32);
            label7.TabIndex = 12;
            label7.Text = "Acquisition #";
            // 
            // AcquisitionNum
            // 
            AcquisitionNum.Location = new Point(899, 24);
            AcquisitionNum.Name = "AcquisitionNum";
            AcquisitionNum.Size = new Size(200, 39);
            AcquisitionNum.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(706, 82);
            label8.Name = "label8";
            label8.Size = new Size(177, 32);
            label8.TabIndex = 14;
            label8.Text = "Recording Tech";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 79);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 15;
            label9.Text = "Location";
            // 
            // locationCombo
            // 
            locationCombo.FormattingEnabled = true;
            locationCombo.Items.AddRange(new object[] { "Long Beach", "Torrance" });
            locationCombo.Location = new Point(258, 79);
            locationCombo.Name = "locationCombo";
            locationCombo.Size = new Size(242, 40);
            locationCombo.TabIndex = 1;
            // 
            // sleepTech
            // 
            sleepTech.Location = new Point(899, 79);
            sleepTech.Name = "sleepTech";
            sleepTech.Size = new Size(200, 39);
            sleepTech.TabIndex = 9;
            // 
            // generateReportBtn
            // 
            generateReportBtn.Location = new Point(471, 1163);
            generateReportBtn.Name = "generateReportBtn";
            generateReportBtn.Size = new Size(208, 51);
            generateReportBtn.TabIndex = 19;
            generateReportBtn.Text = "Generate Report";
            generateReportBtn.UseVisualStyleBackColor = true;
            generateReportBtn.Click += generateReportBtn_Click;
            // 
            // generateReportSplitBtn
            // 
            generateReportSplitBtn.Location = new Point(471, 1163);
            generateReportSplitBtn.Name = "generateReportSplitBtn";
            generateReportSplitBtn.Size = new Size(208, 51);
            generateReportSplitBtn.TabIndex = 22;
            generateReportSplitBtn.Text = "Generate Report";
            generateReportSplitBtn.UseVisualStyleBackColor = true;
            generateReportSplitBtn.Click += generateReportSplitBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(708, 140);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 23;
            label11.Text = "Patient ID";
            // 
            // ptIdBox
            // 
            ptIdBox.Location = new Point(901, 140);
            ptIdBox.Name = "ptIdBox";
            ptIdBox.ReadOnly = true;
            ptIdBox.Size = new Size(200, 39);
            ptIdBox.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(703, 468);
            label12.Name = "label12";
            label12.Size = new Size(157, 32);
            label12.TabIndex = 25;
            label12.Text = "Masked Used";
            // 
            // maskComboBox
            // 
            maskComboBox.FormattingEnabled = true;
            maskComboBox.Location = new Point(901, 465);
            maskComboBox.Name = "maskComboBox";
            maskComboBox.Size = new Size(242, 40);
            maskComboBox.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(45, 396);
            label13.Name = "label13";
            label13.Size = new Size(86, 32);
            label13.TabIndex = 27;
            label13.Text = "Height";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(45, 451);
            label14.Name = "label14";
            label14.Size = new Size(90, 32);
            label14.TabIndex = 28;
            label14.Text = "Weight";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 451);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(63, 137);
            label15.Name = "label15";
            label15.Size = new Size(83, 32);
            label15.TabIndex = 31;
            label15.Text = "Room ";
            // 
            // roomCombo
            // 
            roomCombo.FormattingEnabled = true;
            roomCombo.Items.AddRange(new object[] { "RM1", "RM2", "RM3" });
            roomCombo.Location = new Point(258, 137);
            roomCombo.Name = "roomCombo";
            roomCombo.Size = new Size(242, 40);
            roomCombo.TabIndex = 32;
            roomCombo.SelectedIndexChanged += roomCombo_SelectedIndexChanged;
            // 
            // commentBox
            // 
            commentBox.Location = new Point(63, 913);
            commentBox.Multiline = true;
            commentBox.Name = "commentBox";
            commentBox.Size = new Size(1058, 160);
            commentBox.TabIndex = 33;
            commentBox.Text = "add comments";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(44, 507);
            label16.Name = "label16";
            label16.Size = new Size(101, 32);
            label16.TabIndex = 34;
            label16.Text = "Epworth";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 507);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(449, 509);
            label17.Name = "label17";
            label17.Size = new Size(61, 37);
            label17.TabIndex = 36;
            label17.Text = "/24";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(705, 527);
            label18.Name = "label18";
            label18.Size = new Size(120, 32);
            label18.TabIndex = 37;
            label18.Text = "Mask Size";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "XS", "Small", "Medium", "Large", "XL" });
            comboBox1.Location = new Point(901, 527);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 1230);
            Controls.Add(comboBox1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(textBox3);
            Controls.Add(label16);
            Controls.Add(commentBox);
            Controls.Add(roomCombo);
            Controls.Add(label15);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(maskComboBox);
            Controls.Add(label12);
            Controls.Add(ptIdBox);
            Controls.Add(label11);
            Controls.Add(generateReportSplitBtn);
            Controls.Add(generateReportBtn);
            Controls.Add(sleepTech);
            Controls.Add(locationCombo);
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
        private ComboBox locationCombo;
        private TextBox sleepTech;
        private Button generateReportBtn;
        private Button generateReportSplitBtn;
        private Label label11;
        private TextBox ptIdBox;
        private Label label12;
        private ComboBox maskComboBox;
        private Label label13;
        private Label label14;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label15;
        private ComboBox roomCombo;
        private TextBox commentBox;
        private Label label16;
        private TextBox textBox3;
        private Label label17;
        private Label label18;
        private ComboBox comboBox1;
    }
}
