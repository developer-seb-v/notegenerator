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
            label7 = new Label();
            AcqNumBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            locationCombo = new ComboBox();
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
            label19 = new Label();
            label20 = new Label();
            startPresBox = new TextBox();
            finalPresBox = new TextBox();
            papPanel = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            addTechToolStripMenuItem = new ToolStripMenuItem();
            addMDToolStripMenuItem = new ToolStripMenuItem();
            techComboBox = new ComboBox();
            orderingMDComboBox = new ComboBox();
            papPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 104);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "Date of Study";
            // 
            // dateOfStudy
            // 
            dateOfStudy.Format = DateTimePickerFormat.Short;
            dateOfStudy.Location = new Point(237, 104);
            dateOfStudy.Name = "dateOfStudy";
            dateOfStudy.Size = new Size(400, 39);
            dateOfStudy.TabIndex = 1;
            dateOfStudy.ValueChanged += dateOfStudy_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 315);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 2;
            label2.Text = "Patient Name";
            // 
            // ptNameTextBox
            // 
            ptNameTextBox.Location = new Point(240, 324);
            ptNameTextBox.Name = "ptNameTextBox";
            ptNameTextBox.Size = new Size(398, 39);
            ptNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 379);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 4;
            label3.Text = "Test Ordered";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 376);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 5;
            label4.Text = "Patient DOB";
            // 
            // ptDOB
            // 
            ptDOB.Location = new Point(240, 379);
            ptDOB.Name = "ptDOB";
            ptDOB.Size = new Size(400, 39);
            ptDOB.TabIndex = 8;
            // 
            // studyOrdered
            // 
            studyOrdered.FormattingEnabled = true;
            studyOrdered.Items.AddRange(new object[] { "NPSG", "SPLIT ", "TITRATION" });
            studyOrdered.Location = new Point(852, 379);
            studyOrdered.Name = "studyOrdered";
            studyOrdered.Size = new Size(325, 40);
            studyOrdered.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 442);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 8;
            label5.Text = "Test Conducted";
            // 
            // studyPerformed
            // 
            studyPerformed.FormattingEnabled = true;
            studyPerformed.Items.AddRange(new object[] { "NPSG", "SPLIT", "TITRATION" });
            studyPerformed.Location = new Point(852, 438);
            studyPerformed.Name = "studyPerformed";
            studyPerformed.Size = new Size(325, 40);
            studyPerformed.TabIndex = 14;
            studyPerformed.SelectedIndexChanged += studyPerformed_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(656, 321);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 10;
            label6.Text = "Ordering MD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(687, 161);
            label7.Name = "label7";
            label7.Size = new Size(153, 32);
            label7.TabIndex = 12;
            label7.Text = "Acquisition #";
            // 
            // AcqNumBox
            // 
            AcqNumBox.Location = new Point(870, 161);
            AcqNumBox.Name = "AcqNumBox";
            AcqNumBox.Size = new Size(200, 39);
            AcqNumBox.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(675, 106);
            label8.Name = "label8";
            label8.Size = new Size(177, 32);
            label8.TabIndex = 14;
            label8.Text = "Recording Tech";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 156);
            label9.Name = "label9";
            label9.Size = new Size(104, 32);
            label9.TabIndex = 15;
            label9.Text = "Location";
            // 
            // locationCombo
            // 
            locationCombo.FormattingEnabled = true;
            locationCombo.Items.AddRange(new object[] { "Long Beach", "Torrance" });
            locationCombo.Location = new Point(237, 156);
            locationCombo.Name = "locationCombo";
            locationCombo.Size = new Size(242, 40);
            locationCombo.TabIndex = 2;
            // 
            // generateReportBtn
            // 
            generateReportBtn.Location = new Point(470, 1157);
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
            label11.Location = new Point(687, 222);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 23;
            label11.Text = "Patient ID";
            // 
            // ptIdBox
            // 
            ptIdBox.Location = new Point(870, 222);
            ptIdBox.Name = "ptIdBox";
            ptIdBox.ReadOnly = true;
            ptIdBox.Size = new Size(200, 39);
            ptIdBox.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 46);
            label12.Name = "label12";
            label12.Size = new Size(157, 32);
            label12.TabIndex = 25;
            label12.Text = "Masked Used";
            // 
            // maskComboBox
            // 
            maskComboBox.FormattingEnabled = true;
            maskComboBox.Items.AddRange(new object[] { "OTHER", "RESMED F10 FF MASK", "RESMED F20 FF MASK", "RESMED F30 FF MASK", "RESMED F30i FF MASK", "RESMED F40 FF MASK", "RESMED N20 NASAL MASK", "RESMED N30 NASAL MASK ", "RESMED N30i NASAL MASK ", "RESMED P10 NASAL PILLOWS", "RESMED P30i NASAL PILLOWS", "F & P ESON NASAL MASK", "F & P ESON 2 NASAL MASK", "F & P EVORA NASAL MASK", "F& P EVORA FF MASK", "F & P SIMPLUS FF MASK", "F & P VITERA FF MASK", "RESPIRONICS DREAMWEAR NASAL MASK", "RESPIRONICS DREAMWEAR FF MASK", "RESPIRONICS WISP NASAL MASK", "RESPIRONICS PICO NASAL MASK" });
            maskComboBox.Location = new Point(242, 38);
            maskComboBox.Name = "maskComboBox";
            maskComboBox.Size = new Size(513, 40);
            maskComboBox.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 434);
            label13.Name = "label13";
            label13.Size = new Size(86, 32);
            label13.TabIndex = 27;
            label13.Text = "Height";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 489);
            label14.Name = "label14";
            label14.Size = new Size(90, 32);
            label14.TabIndex = 28;
            label14.Text = "Weight";
            // 
            // heightBox
            // 
            heightBox.Location = new Point(240, 434);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(200, 39);
            heightBox.TabIndex = 9;
            heightBox.TextChanged += heightBox_TextChanged;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(240, 489);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(200, 39);
            weightBox.TabIndex = 10;
            weightBox.TextChanged += weightBox_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 214);
            label15.Name = "label15";
            label15.Size = new Size(83, 32);
            label15.TabIndex = 31;
            label15.Text = "Room ";
            // 
            // roomCombo
            // 
            roomCombo.FormattingEnabled = true;
            roomCombo.Items.AddRange(new object[] { "RM1", "RM2", "RM3" });
            roomCombo.Location = new Point(237, 214);
            roomCombo.Name = "roomCombo";
            roomCombo.Size = new Size(242, 40);
            roomCombo.TabIndex = 3;
            roomCombo.SelectedIndexChanged += roomCombo_SelectedIndexChanged;
            // 
            // commentBox
            // 
            commentBox.Location = new Point(37, 971);
            commentBox.Multiline = true;
            commentBox.Name = "commentBox";
            commentBox.PlaceholderText = "\"{ptName} is in for a {ordered} study.";
            commentBox.Size = new Size(1058, 160);
            commentBox.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(41, 545);
            label16.Name = "label16";
            label16.Size = new Size(101, 32);
            label16.TabIndex = 34;
            label16.Text = "Epworth";
            // 
            // epworthBox
            // 
            epworthBox.Location = new Point(240, 545);
            epworthBox.Name = "epworthBox";
            epworthBox.Size = new Size(200, 39);
            epworthBox.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(446, 547);
            label17.Name = "label17";
            label17.Size = new Size(61, 37);
            label17.TabIndex = 36;
            label17.Text = "/24";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 108);
            label18.Name = "label18";
            label18.Size = new Size(120, 32);
            label18.TabIndex = 37;
            label18.Text = "Mask Size";
            // 
            // maskSizeBox
            // 
            maskSizeBox.FormattingEnabled = true;
            maskSizeBox.Items.AddRange(new object[] { "XS", "Small", "Small Wide", "Wide", "Medium", "Large", "XL" });
            maskSizeBox.Location = new Point(242, 100);
            maskSizeBox.Name = "maskSizeBox";
            maskSizeBox.Size = new Size(325, 40);
            maskSizeBox.TabIndex = 16;
            // 
            // splitBtn
            // 
            splitBtn.Location = new Point(470, 1157);
            splitBtn.Name = "splitBtn";
            splitBtn.Size = new Size(208, 51);
            splitBtn.TabIndex = 39;
            splitBtn.Text = "Generate Report";
            splitBtn.UseVisualStyleBackColor = true;
            splitBtn.Click += splitBtn_Click;
            // 
            // titrationBtn
            // 
            titrationBtn.Location = new Point(470, 1157);
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
            label10.Location = new Point(470, 434);
            label10.Name = "label10";
            label10.Size = new Size(56, 32);
            label10.TabIndex = 40;
            label10.Text = "BMI";
            // 
            // bmiBox
            // 
            bmiBox.Location = new Point(532, 431);
            bmiBox.Name = "bmiBox";
            bmiBox.ReadOnly = true;
            bmiBox.Size = new Size(106, 39);
            bmiBox.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(24, 168);
            label19.Name = "label19";
            label19.Size = new Size(192, 32);
            label19.TabIndex = 42;
            label19.Text = "Starting Pressure";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 234);
            label20.Name = "label20";
            label20.Size = new Size(160, 32);
            label20.TabIndex = 43;
            label20.Text = "Final Pressure";
            // 
            // startPresBox
            // 
            startPresBox.Location = new Point(242, 161);
            startPresBox.Name = "startPresBox";
            startPresBox.Size = new Size(200, 39);
            startPresBox.TabIndex = 44;
            // 
            // finalPresBox
            // 
            finalPresBox.Location = new Point(242, 227);
            finalPresBox.Name = "finalPresBox";
            finalPresBox.Size = new Size(200, 39);
            finalPresBox.TabIndex = 45;
            // 
            // papPanel
            // 
            papPanel.Controls.Add(maskComboBox);
            papPanel.Controls.Add(finalPresBox);
            papPanel.Controls.Add(label12);
            papPanel.Controls.Add(startPresBox);
            papPanel.Controls.Add(label18);
            papPanel.Controls.Add(label20);
            papPanel.Controls.Add(maskSizeBox);
            papPanel.Controls.Add(label19);
            papPanel.Location = new Point(43, 631);
            papPanel.Name = "papPanel";
            papPanel.Size = new Size(790, 298);
            papPanel.TabIndex = 46;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, databaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1285, 40);
            menuStrip1.TabIndex = 47;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTechToolStripMenuItem, addMDToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(132, 36);
            databaseToolStripMenuItem.Text = "Database";
            // 
            // addTechToolStripMenuItem
            // 
            addTechToolStripMenuItem.Name = "addTechToolStripMenuItem";
            addTechToolStripMenuItem.Size = new Size(246, 44);
            addTechToolStripMenuItem.Text = "Add Tech";
            addTechToolStripMenuItem.Click += addTechToolStripMenuItem_Click;
            // 
            // addMDToolStripMenuItem
            // 
            addMDToolStripMenuItem.Name = "addMDToolStripMenuItem";
            addMDToolStripMenuItem.Size = new Size(246, 44);
            addMDToolStripMenuItem.Text = "Add MD";
            addMDToolStripMenuItem.Click += addMDToolStripMenuItem_Click;
            // 
            // techComboBox
            // 
            techComboBox.FormattingEnabled = true;
            techComboBox.Location = new Point(870, 106);
            techComboBox.Name = "techComboBox";
            techComboBox.Size = new Size(365, 40);
            techComboBox.TabIndex = 48;
            // 
            // orderingMDComboBox
            // 
            orderingMDComboBox.FormattingEnabled = true;
            orderingMDComboBox.Location = new Point(853, 325);
            orderingMDComboBox.Name = "orderingMDComboBox";
            orderingMDComboBox.Size = new Size(242, 40);
            orderingMDComboBox.TabIndex = 49;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 1230);
            Controls.Add(orderingMDComboBox);
            Controls.Add(techComboBox);
            Controls.Add(papPanel);
            Controls.Add(bmiBox);
            Controls.Add(label10);
            Controls.Add(titrationBtn);
            Controls.Add(splitBtn);
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
            Controls.Add(ptIdBox);
            Controls.Add(label11);
            Controls.Add(generateReportBtn);
            Controls.Add(locationCombo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AcqNumBox);
            Controls.Add(label7);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Generate Report ";
            papPanel.ResumeLayout(false);
            papPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label7;
        private TextBox AcqNumBox;
        private Label label8;
        private Label label9;
        private ComboBox locationCombo;
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
        private Label label19;
        private Label label20;
        private TextBox startPresBox;
        private TextBox finalPresBox;
        private Panel papPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem addTechToolStripMenuItem;
        private ToolStripMenuItem addMDToolStripMenuItem;
        private ComboBox techComboBox;
        private ComboBox orderingMDComboBox;
    }
}
