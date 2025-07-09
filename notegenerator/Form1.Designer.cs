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
            AcqNumBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            locationCombo = new ComboBox();
            sleepTechBox = new TextBox();
            generateReportBtn = new Button();
            label11 = new Label();
            ptIdBox = new TextBox();
            label12 = new Label();
            maskComboBox = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            heightBox = new TextBox();
            weightBox = new TextBox();
            label15 = new Label();
            roomCombo = new ComboBox();
            commentBox = new TextBox();
            label16 = new Label();
            epworthBox = new TextBox();
            label17 = new Label();
            label18 = new Label();
            maskSizeBox = new ComboBox();
            splitBtn = new Button();
            titrationBtn = new Button();
            label10 = new Label();
            bmiBox = new TextBox();
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
            dateOfStudy.TabIndex = 1;
            dateOfStudy.ValueChanged += dateOfStudy_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 238);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 2;
            label2.Text = "Patient Name";
            // 
            // ptNameTextBox
            // 
            ptNameTextBox.Location = new Point(261, 247);
            ptNameTextBox.Name = "ptNameTextBox";
            ptNameTextBox.Size = new Size(398, 39);
            ptNameTextBox.TabIndex = 7;
            ptNameTextBox.TextChanged += ptNameTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 302);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 4;
            label3.Text = "Test Ordered";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 299);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 5;
            label4.Text = "Patient DOB";
            // 
            // ptDOB
            // 
            ptDOB.Location = new Point(261, 302);
            ptDOB.Name = "ptDOB";
            ptDOB.Size = new Size(400, 39);
            ptDOB.TabIndex = 8;
            // 
            // studyOrdered
            // 
            studyOrdered.FormattingEnabled = true;
            studyOrdered.Items.AddRange(new object[] { "NPSG", "SPLIT ", "TITRATION" });
            studyOrdered.Location = new Point(873, 302);
            studyOrdered.Name = "studyOrdered";
            studyOrdered.Size = new Size(325, 40);
            studyOrdered.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 365);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 8;
            label5.Text = "Test Conducted";
            // 
            // studyPerformed
            // 
            studyPerformed.FormattingEnabled = true;
            studyPerformed.Items.AddRange(new object[] { "NPSG", "SPLIT", "TITRATION" });
            studyPerformed.Location = new Point(873, 361);
            studyPerformed.Name = "studyPerformed";
            studyPerformed.Size = new Size(325, 40);
            studyPerformed.TabIndex = 14;
            studyPerformed.SelectedIndexChanged += studyPerformed_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(677, 244);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 10;
            label6.Text = "Ordering MD";
            // 
            // refMDtxtBox
            // 
            refMDtxtBox.Location = new Point(873, 247);
            refMDtxtBox.Name = "refMDtxtBox";
            refMDtxtBox.Size = new Size(325, 39);
            refMDtxtBox.TabIndex = 12;
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
            // AcqNumBox
            // 
            AcqNumBox.Location = new Point(899, 24);
            AcqNumBox.Name = "AcqNumBox";
            AcqNumBox.Size = new Size(200, 39);
            AcqNumBox.TabIndex = 4;
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
            locationCombo.TabIndex = 2;
            // 
            // sleepTechBox
            // 
            sleepTechBox.Location = new Point(899, 79);
            sleepTechBox.Name = "sleepTechBox";
            sleepTechBox.Size = new Size(200, 39);
            sleepTechBox.TabIndex = 5;
            // 
            // generateReportBtn
            // 
            generateReportBtn.Location = new Point(474, 1127);
            generateReportBtn.Name = "generateReportBtn";
            generateReportBtn.Size = new Size(208, 51);
            generateReportBtn.TabIndex = 19;
            generateReportBtn.Text = "Generate Report";
            generateReportBtn.UseVisualStyleBackColor = true;
            generateReportBtn.Click += generateReportBtn_Click;
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
            ptIdBox.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(675, 423);
            label12.Name = "label12";
            label12.Size = new Size(157, 32);
            label12.TabIndex = 25;
            label12.Text = "Masked Used";
            // 
            // maskComboBox
            // 
            maskComboBox.FormattingEnabled = true;
            maskComboBox.Items.AddRange(new object[] { "OTHER", "RESMED F10 FF MASK", "RESMED F20 FF MASK", "RESMED F30 FF MASK", "RESMED F30i FF MASK", "RESMED F40 FF MASK", "RESMED N20 NASAL MASK", "RESMED N30 NASAL MASK ", "RESMED N30i NASAL MASK ", "RESMED P10 NASAL PILLOWS", "RESMED P30i NASAL PILLOWS", "F & P ESON NASAL MASK", "F & P ESON 2 NASAL MASK", "F & P EVORA NASAL MASK", "F& P EVORA FF MASK", "F & P SIMPLUS FF MASK", "F & P VITERA FF MASK", "RESPIRONICS DREAMWEAR NASAL MASK", "RESPIRONICS DREAMWEAR FF MASK", "RESPIRONICS WISP NASAL MASK", "RESPIRONICS PICO NASAL MASK" });
            maskComboBox.Location = new Point(873, 420);
            maskComboBox.Name = "maskComboBox";
            maskComboBox.Size = new Size(513, 40);
            maskComboBox.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 357);
            label13.Name = "label13";
            label13.Size = new Size(86, 32);
            label13.TabIndex = 27;
            label13.Text = "Height";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 412);
            label14.Name = "label14";
            label14.Size = new Size(90, 32);
            label14.TabIndex = 28;
            label14.Text = "Weight";
            // 
            // heightBox
            // 
            heightBox.Location = new Point(261, 357);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(200, 39);
            heightBox.TabIndex = 9;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(261, 412);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(200, 39);
            weightBox.TabIndex = 10;
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
            roomCombo.TabIndex = 3;
            roomCombo.SelectedIndexChanged += roomCombo_SelectedIndexChanged;
            // 
            // commentBox
            // 
            commentBox.Location = new Point(63, 913);
            commentBox.Multiline = true;
            commentBox.Name = "commentBox";
            commentBox.Size = new Size(1058, 160);
            commentBox.TabIndex = 17;
            commentBox.Text = "add comments";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(62, 468);
            label16.Name = "label16";
            label16.Size = new Size(101, 32);
            label16.TabIndex = 34;
            label16.Text = "Epworth";
            // 
            // epworthBox
            // 
            epworthBox.Location = new Point(261, 468);
            epworthBox.Name = "epworthBox";
            epworthBox.Size = new Size(200, 39);
            epworthBox.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(467, 470);
            label17.Name = "label17";
            label17.Size = new Size(61, 37);
            label17.TabIndex = 36;
            label17.Text = "/24";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(677, 482);
            label18.Name = "label18";
            label18.Size = new Size(120, 32);
            label18.TabIndex = 37;
            label18.Text = "Mask Size";
            // 
            // maskSizeBox
            // 
            maskSizeBox.FormattingEnabled = true;
            maskSizeBox.Items.AddRange(new object[] { "XS", "Small", "Small Wide", "Wide", "Medium", "Large", "XL" });
            maskSizeBox.Location = new Point(873, 482);
            maskSizeBox.Name = "maskSizeBox";
            maskSizeBox.Size = new Size(325, 40);
            maskSizeBox.TabIndex = 16;
            // 
            // splitBtn
            // 
            splitBtn.Location = new Point(474, 1127);
            splitBtn.Name = "splitBtn";
            splitBtn.Size = new Size(208, 51);
            splitBtn.TabIndex = 39;
            splitBtn.Text = "Generate Report";
            splitBtn.UseVisualStyleBackColor = true;
            splitBtn.Click += splitBtn_Click;
            // 
            // titrationBtn
            // 
            titrationBtn.Location = new Point(474, 1127);
            titrationBtn.Name = "titrationBtn";
            titrationBtn.Size = new Size(208, 51);
            titrationBtn.TabIndex = 18;
            titrationBtn.Text = "Generate Report";
            titrationBtn.UseVisualStyleBackColor = true;
            titrationBtn.Click += titrationBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(491, 357);
            label10.Name = "label10";
            label10.Size = new Size(56, 32);
            label10.TabIndex = 40;
            label10.Text = "BMI";
            // 
            // bmiBox
            // 
            bmiBox.Location = new Point(553, 354);
            bmiBox.Name = "bmiBox";
            bmiBox.ReadOnly = true;
            bmiBox.Size = new Size(106, 39);
            bmiBox.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 1230);
            Controls.Add(bmiBox);
            Controls.Add(label10);
            Controls.Add(titrationBtn);
            Controls.Add(splitBtn);
            Controls.Add(maskSizeBox);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(epworthBox);
            Controls.Add(label16);
            Controls.Add(commentBox);
            Controls.Add(roomCombo);
            Controls.Add(label15);
            Controls.Add(weightBox);
            Controls.Add(heightBox);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(maskComboBox);
            Controls.Add(label12);
            Controls.Add(ptIdBox);
            Controls.Add(label11);
            Controls.Add(generateReportBtn);
            Controls.Add(sleepTechBox);
            Controls.Add(locationCombo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AcqNumBox);
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
        private TextBox AcqNumBox;
        private Label label8;
        private Label label9;
        private ComboBox locationCombo;
        private TextBox sleepTechBox;
        private Button generateReportBtn;
        private Label label11;
        private TextBox ptIdBox;
        private Label label12;
        private ComboBox maskComboBox;
        private Label label13;
        private Label label14;
        private TextBox heightBox;
        private TextBox weightBox;
        private Label label15;
        private ComboBox roomCombo;
        private TextBox commentBox;
        private Label label16;
        private TextBox epworthBox;
        private Label label17;
        private Label label18;
        private ComboBox maskSizeBox;
        private Button splitBtn;
        private Button titrationBtn;
        private Label label10;
        private TextBox bmiBox;
    }
}
