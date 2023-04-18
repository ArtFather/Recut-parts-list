using AirtableApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        DataGridView dataGridView1 = ((Form1)Application.OpenForms["Form1"]).dataGridView1;
        public Form2()
        {
            InitializeComponent();
            int i = 0;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                CheckBox checkbox = new CheckBox();
                checkbox.Text = column.HeaderText;
                checkbox.Height = 20;
                checkbox.Location = new Point(10, i);
                checkbox.CheckedChanged += new EventHandler(Changecheck);

                if(column.Visible != true)
                {
                    checkbox.Checked = true;
                }
                
                this.panel1.Controls.Add(checkbox);
                i += 20;
            }

        }

        private void Changecheck(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if(checkbox.CheckState.ToString() != "Checked")
            {
                dataGridView1.Columns[checkbox.Text].Visible = true;
            }
            else
            {
                dataGridView1.Columns[checkbox.Text].Visible = false;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}
