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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get data";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 402);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // LineOneBut
            // 
            this.LineOneBut.Location = new System.Drawing.Point(151, 12);
            this.LineOneBut.Name = "LineOneBut";
            this.LineOneBut.Size = new System.Drawing.Size(143, 39);
            this.LineOneBut.TabIndex = 6;
            this.LineOneBut.Text = "Line 1";
            this.LineOneBut.UseVisualStyleBackColor = true;
            this.LineOneBut.Click += new System.EventHandler(this.LineOneBut_Click);
            // 
            // LineTwoBut
            // 
            this.LineTwoBut.Location = new System.Drawing.Point(300, 12);
            this.LineTwoBut.Name = "LineTwoBut";
            this.LineTwoBut.Size = new System.Drawing.Size(143, 39);
            this.LineTwoBut.TabIndex = 7;
            this.LineTwoBut.Text = "Line 2";
            this.LineTwoBut.UseVisualStyleBackColor = true;
            this.LineTwoBut.Click += new System.EventHandler(this.LineTwoBut_Click);
            // 
            // LineThreeBut
            // 
            this.LineThreeBut.Location = new System.Drawing.Point(449, 13);
            this.LineThreeBut.Name = "LineThreeBut";
            this.LineThreeBut.Size = new System.Drawing.Size(143, 39);
            this.LineThreeBut.TabIndex = 8;
            this.LineThreeBut.Text = "Line 3";
            this.LineThreeBut.UseVisualStyleBackColor = true;
            this.LineThreeBut.Click += new System.EventHandler(this.LineThreeBut_Click);
            // 
            // LineFourBut
            // 
            this.LineFourBut.Location = new System.Drawing.Point(598, 12);
            this.LineFourBut.Name = "LineFourBut";
            this.LineFourBut.Size = new System.Drawing.Size(143, 39);
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
            this.label2.Location = new System.Drawing.Point(1091, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
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
            this.label3.Location = new System.Drawing.Point(1177, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 16;
            // 
            // notLineBt
            // 
            this.notLineBt.Location = new System.Drawing.Point(747, 12);
            this.notLineBt.Name = "notLineBt";
            this.notLineBt.Size = new System.Drawing.Size(143, 39);
            this.notLineBt.TabIndex = 17;
            this.notLineBt.Text = "Line";
            this.notLineBt.UseVisualStyleBackColor = true;
            this.notLineBt.Click += new System.EventHandler(this.notLineBt_Click);
            // 
            // notCutBt
            // 
            this.notCutBt.Location = new System.Drawing.Point(896, 12);
            this.notCutBt.Name = "notCutBt";
            this.notCutBt.Size = new System.Drawing.Size(143, 39);
            this.notCutBt.TabIndex = 18;
            this.notCutBt.Text = "Undone";
            this.notCutBt.UseVisualStyleBackColor = true;
            this.notCutBt.Click += new System.EventHandler(this.notCutBt_Click);
            // 
            // updatesCounterL
            // 
            this.updatesCounterL.AutoSize = true;
            this.updatesCounterL.Location = new System.Drawing.Point(1046, 22);
            this.updatesCounterL.Name = "updatesCounterL";
            this.updatesCounterL.Size = new System.Drawing.Size(0, 16);
            this.updatesCounterL.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1260, 471);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LineOneBut;
        private System.Windows.Forms.Button LineTwoBut;
        private System.Windows.Forms.Button LineThreeBut;
        private System.Windows.Forms.Button LineFourBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button notLineBt;
        private System.Windows.Forms.Button notCutBt;
        private System.Windows.Forms.Label updatesCounterL;
    }
}

