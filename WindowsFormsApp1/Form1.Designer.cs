namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LineOneBut = new System.Windows.Forms.Button();
            this.LineTwoBut = new System.Windows.Forms.Button();
            this.LineThreeBut = new System.Windows.Forms.Button();
            this.LineFourBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.notLineBt = new System.Windows.Forms.Button();
            this.notCutBt = new System.Windows.Forms.Button();
            this.updatesCounterL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 417);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // LineOneBut
            // 
            this.LineOneBut.Location = new System.Drawing.Point(113, 10);
            this.LineOneBut.Margin = new System.Windows.Forms.Padding(2);
            this.LineOneBut.Name = "LineOneBut";
            this.LineOneBut.Size = new System.Drawing.Size(107, 32);
            this.LineOneBut.TabIndex = 6;
            this.LineOneBut.Text = "Line 1";
            this.LineOneBut.UseVisualStyleBackColor = true;
            this.LineOneBut.Click += new System.EventHandler(this.LineOneBut_Click);
            // 
            // LineTwoBut
            // 
            this.LineTwoBut.Location = new System.Drawing.Point(225, 10);
            this.LineTwoBut.Margin = new System.Windows.Forms.Padding(2);
            this.LineTwoBut.Name = "LineTwoBut";
            this.LineTwoBut.Size = new System.Drawing.Size(107, 32);
            this.LineTwoBut.TabIndex = 7;
            this.LineTwoBut.Text = "Line 2";
            this.LineTwoBut.UseVisualStyleBackColor = true;
            this.LineTwoBut.Click += new System.EventHandler(this.LineTwoBut_Click);
            // 
            // LineThreeBut
            // 
            this.LineThreeBut.Location = new System.Drawing.Point(337, 11);
            this.LineThreeBut.Margin = new System.Windows.Forms.Padding(2);
            this.LineThreeBut.Name = "LineThreeBut";
            this.LineThreeBut.Size = new System.Drawing.Size(107, 32);
            this.LineThreeBut.TabIndex = 8;
            this.LineThreeBut.Text = "Line 3";
            this.LineThreeBut.UseVisualStyleBackColor = true;
            this.LineThreeBut.Click += new System.EventHandler(this.LineThreeBut_Click);
            // 
            // LineFourBut
            // 
            this.LineFourBut.Location = new System.Drawing.Point(448, 10);
            this.LineFourBut.Margin = new System.Windows.Forms.Padding(2);
            this.LineFourBut.Name = "LineFourBut";
            this.LineFourBut.Size = new System.Drawing.Size(107, 32);
            this.LineFourBut.TabIndex = 9;
            this.LineFourBut.Text = "Line 4";
            this.LineFourBut.UseVisualStyleBackColor = true;
            this.LineFourBut.Click += new System.EventHandler(this.LineFourBut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // notLineBt
            // 
            this.notLineBt.Location = new System.Drawing.Point(560, 10);
            this.notLineBt.Margin = new System.Windows.Forms.Padding(2);
            this.notLineBt.Name = "notLineBt";
            this.notLineBt.Size = new System.Drawing.Size(107, 32);
            this.notLineBt.TabIndex = 17;
            this.notLineBt.Text = "Line";
            this.notLineBt.UseVisualStyleBackColor = true;
            this.notLineBt.Click += new System.EventHandler(this.notLineBt_Click);
            // 
            // notCutBt
            // 
            this.notCutBt.Location = new System.Drawing.Point(672, 10);
            this.notCutBt.Margin = new System.Windows.Forms.Padding(2);
            this.notCutBt.Name = "notCutBt";
            this.notCutBt.Size = new System.Drawing.Size(107, 32);
            this.notCutBt.TabIndex = 18;
            this.notCutBt.Text = "Not done";
            this.notCutBt.UseVisualStyleBackColor = true;
            this.notCutBt.Click += new System.EventHandler(this.notCutBt_Click);
            // 
            // updatesCounterL
            // 
            this.updatesCounterL.AutoSize = true;
            this.updatesCounterL.Location = new System.Drawing.Point(784, 18);
            this.updatesCounterL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updatesCounterL.Name = "updatesCounterL";
            this.updatesCounterL.Size = new System.Drawing.Size(0, 13);
            this.updatesCounterL.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select cell to search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(278, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "9";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Font size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 25;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 20);
            this.button2.TabIndex = 26;
            this.button2.Text = "Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Updating...";
            this.label7.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "10";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(800, 46);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 20);
            this.button3.TabIndex = 30;
            this.button3.Text = "Fields";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(950, 496);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updatesCounterL);
            this.Controls.Add(this.notCutBt);
            this.Controls.Add(this.notLineBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LineFourBut);
            this.Controls.Add(this.LineThreeBut);
            this.Controls.Add(this.LineTwoBut);
            this.Controls.Add(this.LineOneBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Recut parts list";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dataSet1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LineOneBut;
        private System.Windows.Forms.Button LineTwoBut;
        private System.Windows.Forms.Button LineThreeBut;
        private System.Windows.Forms.Button LineFourBut;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button notLineBt;
        private System.Windows.Forms.Button notCutBt;
        private System.Windows.Forms.Label updatesCounterL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}

