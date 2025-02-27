namespace WinFormsCalc
{
    partial class FormAbout
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
            CloseAbout = new Button();
            AboutLabel = new Label();
            SuspendLayout();
            // 
            // CloseAbout
            // 
            CloseAbout.Location = new Point(104, 80);
            CloseAbout.Name = "CloseAbout";
            CloseAbout.Size = new Size(75, 23);
            CloseAbout.TabIndex = 0;
            CloseAbout.Text = "Закрыть";
            CloseAbout.UseVisualStyleBackColor = true;
            CloseAbout.Click += CloseAbout_Click;
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Location = new Point(78, 22);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(131, 15);
            AboutLabel.TabIndex = 1;
            AboutLabel.Text = "Тестовый калькулятор";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 115);
            Controls.Add(AboutLabel);
            Controls.Add(CloseAbout);
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseAbout;
        private Label AboutLabel;
    }
}