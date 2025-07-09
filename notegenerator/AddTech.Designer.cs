namespace notegenerator
{
    partial class AddTech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            techTxtBox = new TextBox();
            addTechBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 98);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Tech";
            // 
            // techTxtBox
            // 
            techTxtBox.Location = new Point(239, 103);
            techTxtBox.Name = "techTxtBox";
            techTxtBox.Size = new Size(356, 39);
            techTxtBox.TabIndex = 1;
            // 
            // addTechBtn
            // 
            addTechBtn.Location = new Point(239, 171);
            addTechBtn.Name = "addTechBtn";
            addTechBtn.Size = new Size(150, 46);
            addTechBtn.TabIndex = 2;
            addTechBtn.Text = "Add Tech";
            addTechBtn.UseVisualStyleBackColor = true;
            addTechBtn.Click += addTechBtn_Click;
            // 
            // AddTech
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 321);
            Controls.Add(addTechBtn);
            Controls.Add(techTxtBox);
            Controls.Add(label1);
            Name = "AddTech";
            Text = "AddTech";
            Load += AddTech_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox techTxtBox;
        private Button addTechBtn;
    }
}