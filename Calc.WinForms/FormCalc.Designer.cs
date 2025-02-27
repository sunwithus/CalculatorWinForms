namespace WinFormsCalc
{
    partial class FormCalc
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            clearButton = new Button();
            Equals = new Button();
            Add = new Button();
            Divide = new Button();
            Multiply = new Button();
            Subtract = new Button();
            richTextBox1 = new RichTextBox();
            About = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 246);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(75, 246);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(150, 246);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(0, 171);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 3;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(75, 171);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(150, 171);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(150, 96);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(75, 96);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(0, 96);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(75, 321);
            button0.Margin = new Padding(0);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            clearButton.Location = new Point(0, 321);
            clearButton.Margin = new Padding(0);
            clearButton.Name = "ClearButton";
            clearButton.Size = new Size(75, 75);
            clearButton.TabIndex = 11;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // Equals
            // 
            Equals.Location = new Point(150, 321);
            Equals.Margin = new Padding(0);
            Equals.Name = "Equals";
            Equals.Size = new Size(75, 75);
            Equals.TabIndex = 12;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = true;
            Equals.Click += Equals_Click;
            // 
            // Add
            // 
            Add.Location = new Point(225, 321);
            Add.Margin = new Padding(0);
            Add.Name = "Add";
            Add.Size = new Size(75, 75);
            Add.TabIndex = 16;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += OperationButton_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(225, 96);
            Divide.Margin = new Padding(0);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 75);
            Divide.TabIndex = 15;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += OperationButton_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(225, 171);
            Multiply.Margin = new Padding(0);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 75);
            Multiply.TabIndex = 14;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += OperationButton_Click;
            // 
            // Subtract
            // 
            Subtract.Location = new Point(225, 246);
            Subtract.Margin = new Padding(0);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(75, 75);
            Subtract.TabIndex = 13;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += OperationButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 50F);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(301, 96);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // About
            // 
            About.Location = new Point(0, 399);
            About.Name = "About";
            About.Size = new Size(300, 23);
            About.TabIndex = 18;
            About.Text = "О программе";
            About.UseVisualStyleBackColor = true;
            About.Click += About_Click;
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 426);
            Controls.Add(About);
            Controls.Add(richTextBox1);
            Controls.Add(Add);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(Equals);
            Controls.Add(clearButton);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCalc";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button clearButton;
        private Button Equals;
        private Button Add;
        private Button Divide;
        private Button Multiply;
        private Button Subtract;
        private RichTextBox richTextBox1;
        private Button About;
    }
}
