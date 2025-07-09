namespace notegenerator
{
    partial class AddMd
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
            addMdBtn = new Button();
            mdTxtBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // addMdBtn
            // 
            addMdBtn.Location = new Point(249, 180);
            addMdBtn.Name = "addMdBtn";
            addMdBtn.Size = new Size(150, 46);
            addMdBtn.TabIndex = 5;
            addMdBtn.Text = "Add MD";
            addMdBtn.UseVisualStyleBackColor = true;
            addMdBtn.Click += addMdBtn_Click;
            // 
            // mdTxtBox
            // 
            mdTxtBox.Location = new Point(249, 112);
            mdTxtBox.Name = "mdTxtBox";
            mdTxtBox.Size = new Size(356, 39);
            mdTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 107);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 3;
            label1.Text = "MD Name";
            // 
            // AddMd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 313);
            Controls.Add(addMdBtn);
            Controls.Add(mdTxtBox);
            Controls.Add(label1);
            Name = "AddMd";
            Text = "AddMd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addMdBtn;
        private TextBox mdTxtBox;
        private Label label1;
    }
}