using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Recut
{
    public partial class Setting : Form
    {
        Timer timer1 = ((Form1)Application.OpenForms["Form1"]).timer1;

        public Setting()
        {
            InitializeComponent();
            textBox1.Text = (timer1.Interval/1000).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text)*1000;
            this.Close();
        }
    }
}
