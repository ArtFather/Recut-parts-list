using AirtableApiClient;
using Recut;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        List<AirtableRecord> records = new List<AirtableRecord>();
        List<AirtableRecord> cutRecords = new List<AirtableRecord>();
        public IEnumerable<string> fields = new string[] { "Order #", "Part # +", "QTY", "NAME", "DATE", "Run Number (from Master List)", "MATERIAL/COLOUR", "REASON FOR REORDER", "Mill Routing Code", "COMMENT", "WC #", "Optimized", "Optimized Date", "Rush", "Cut @ Router Time" };
        string filterField = "Mill Routing Code";
        string selecedColumn = "Mill Routing Code";
        string filter = "";
        int filterOption = 1;
        int errorCounter = 0;
        int updateCounter = 0;
        int recordsToCut = 100;


        public Form1()
        {
            
            InitializeComponent();
           
            foreach (string field in fields)
            {
                dt.Columns.Add(field);

            }

            textBox2.Text = recordsToCut.ToString();
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView1.RowHeadersVisible = false;
            
            getData();
        }

        public async void getData()
        {
            records.Clear();
            string appKey = ConfigurationManager.AppSettings["appKey"];
            string baseId = ConfigurationManager.AppSettings["baseId"];
            string table = ConfigurationManager.AppSettings["table"];

            string tableview = "Master List";
            string offset = null;
            string errorMessage = null;
            string timeZone = "America/North_Dakota/Center";
            string cellFormat = "string";
            string userLocale = "en-ca";
            //string filterByFormula = "{Mill Routing Code} = 2";
            //string filterByFormula = "FIND('1', {Mill Routing Code}) > 0";


           // button2.Visible = false;
            updatesCounterL.Text = updateCounter++.ToString();
                
                label7.Visible = true;

                try
                {
                    using (AirtableBase airtableBase = new AirtableBase(appKey, baseId))
                    {
                        TimeSpan interval = new TimeSpan(0, timer1.Interval / 60000, 0);
                        label3.Text = (DateTime.Now + interval).ToString("HH:mm:ss");
                        do
                        {
                            Task<AirtableListRecordsResponse> task = airtableBase.ListRecords(
                                   table,
                                   offset,
                                   fields,
                                   null,
                                   null,
                                   null,
                                   null,
                                   tableview,
                                   cellFormat,
                                   timeZone,
                                   userLocale,
                                   false
                               );

                            AirtableListRecordsResponse response = await task;

                            if (response.Success)
                            {
                                records.AddRange(response.Records.ToList());
                                offset = response.Offset;
                            }
                            else if (response.AirtableApiError is AirtableApiException)
                            {
                                errorMessage = response.AirtableApiError.ErrorMessage;
                                if (response.AirtableApiError is AirtableInvalidRequestException)
                                {
                                    errorMessage += "\nDetailed error message: ";
                                    errorMessage += response.AirtableApiError.DetailedErrorMessage;
                                    MessageBox.Show(errorMessage);
                                }
                                break;
                            }
                            else
                            {
                                errorMessage = "Unknown error";
                                MessageBox.Show(errorMessage);
                                break;
                            }
                        } while (offset != null);
                    }

                }
                catch (Exception ex)
                {
                    label4.Text = ex.Message;
                    errorCounter++;
                    label6.Text = errorCounter.ToString();
                    button2.Visible = true;
                }

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }

                else
                {
                    updateTable();
                    label7.Visible = false;

                }
            
        }

        private void updateTable()
        {
            cutRecords.Clear();
            dt.Clear();
            recordsToCut = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            cutRecords.AddRange(records.AsEnumerable().Reverse().Take(recordsToCut));

            foreach (var record in cutRecords)
            {
                DataRow dr = dt.NewRow();

                foreach (var columns in record.Fields)
                {
                    dr[columns.Key.ToString()] = columns.Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
            filterProcessor(selecedColumn, filter, filterOption);


        }


        private void filterProcessor(string filterfield, string line, int opt)
        {
            selecedColumn = filterfield;
            filterOption = opt;
            filter = line;

            {
                if (opt != 2)
                {
                    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterfield, line);
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format("[{0}] IS NULL", filterfield);
                }

                foreach (DataGridViewRow myRow in dataGridView1.Rows)
                {
                    if (myRow.Cells[13].Value.ToString() == "**RUSH**")
                    {
                        myRow.DefaultCellStyle.BackColor = Color.IndianRed;
                        myRow.DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if (myRow.Cells[14].Value.ToString() != string.Empty)
                    {
                        myRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
            
            int countRecords = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                countRecords += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label8.Text = countRecords.ToString();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Setting setting = new Setting();
                setting.Show();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            butStatus();
            button1.Enabled = false;
            filterProcessor(filterField, "", 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LineOneBut_Click(object sender, EventArgs e)
        {
            butStatus();
            LineOneBut.Enabled = false;
            filterProcessor(filterField, "1", 1);
        }

        private void LineTwoBut_Click(object sender, EventArgs e)
        {
            butStatus();
            LineTwoBut.Enabled = false;
            filterProcessor(filterField, "2", 1);
        }

        private void LineThreeBut_Click(object sender, EventArgs e)
        {
            butStatus();
            LineThreeBut.Enabled = false;
            filterProcessor(filterField, "3", 1);
        }

        private void LineFourBut_Click(object sender, EventArgs e)
        {
            butStatus();
            LineFourBut.Enabled = false;
            filterProcessor(filterField, "4", 1);
        }

        private void notLineBt_Click(object sender, EventArgs e)
        {
            butStatus();
            notLineBt.Enabled = false;
            filterProcessor(filterField, "[*]", 1);
        }

        private void butStatus()
        {
            button1.Enabled = true;
            LineOneBut.Enabled = true;
            LineTwoBut.Enabled = true;
            LineThreeBut.Enabled = true;
            LineFourBut.Enabled = true;
            notCutBt.Enabled = true;
            notLineBt.Enabled = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow myRow in dataGridView1.Rows)
            {
                if (myRow.Cells[13].Value.ToString() == "**RUSH**")
                {
                    myRow.DefaultCellStyle.BackColor = Color.IndianRed;
                    myRow.DefaultCellStyle.ForeColor = Color.Black;
                }

                if (myRow.Cells[14].Value.ToString() != string.Empty)
                {
                    myRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void notCutBt_Click(object sender, EventArgs e)
        {
            butStatus();
            notCutBt.Enabled = false;
            filterProcessor("Cut @ Router Time", "", 2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterProcessor(selecedColumn, textBox1.Text, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", int.Parse(comboBox1.GetItemText(comboBox1.SelectedItem)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getData();
            //button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecedColumn = fields.ElementAt(e.ColumnIndex);
            label1.Text = selecedColumn;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
