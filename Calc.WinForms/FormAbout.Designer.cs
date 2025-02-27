namespace Calc.WinForms;

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
        HelloButton = new Button();
        SuspendLayout();
        // 
        // CloseAbout
        // 
        CloseAbout.Location = new Point(12, 37);
        CloseAbout.Name = "CloseAbout";
        CloseAbout.Size = new Size(221, 30);
        CloseAbout.TabIndex = 0;
        CloseAbout.Text = "Закрыть";
        CloseAbout.UseVisualStyleBackColor = true;
        CloseAbout.Click += CloseAbout_Click;
        // 
        // AboutLabel
        // 
        AboutLabel.AutoSize = true;
        AboutLabel.Location = new Point(12, 9);
        AboutLabel.Name = "AboutLabel";
        AboutLabel.RightToLeft = RightToLeft.Yes;
        AboutLabel.Size = new Size(131, 15);
        AboutLabel.TabIndex = 1;
        AboutLabel.Text = "Тестовый калькулятор";
        AboutLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HelloButton
        // 
        HelloButton.Location = new Point(158, 5);
        HelloButton.Name = "HelloButton";
        HelloButton.Size = new Size(75, 23);
        HelloButton.TabIndex = 2;
        HelloButton.Text = "Привет!";
        HelloButton.UseVisualStyleBackColor = true;
        HelloButton.Click += HelloButton_Click;
        // 
        // FormAbout
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(247, 82);
        Controls.Add(HelloButton);
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
    private Button HelloButton;
}