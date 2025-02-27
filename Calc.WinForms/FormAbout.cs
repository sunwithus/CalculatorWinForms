using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Calc.WinForms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void CloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void HelloButton_Click(object sender, EventArgs e)
        {
            this.AboutLabel.Text = "🌟 И тебе привет 👋";
            await Task.Delay(2000);
            this.Close();
        }

    }
}
