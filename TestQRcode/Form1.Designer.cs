using System;
using System.Windows.Forms;

namespace TestQRcode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colQRCodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColqrCodeNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColproductName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltype1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colweight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colstats1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coleitime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colstime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(260, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(90, 19);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(155, 21);
            this.cboDevice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera device";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(9, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 233);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQRCodeNumber,
            this.ColProductName,
            this.ColWeight});
            this.dataGridView1.Location = new System.Drawing.Point(534, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 333);
            this.dataGridView1.TabIndex = 5;
            // 
            // colQRCodeNumber
            // 
            this.colQRCodeNumber.DataPropertyName = "Number";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQRCodeNumber.DefaultCellStyle = dataGridViewCellStyle11;
            this.colQRCodeNumber.HeaderText = "Mã code";
            this.colQRCodeNumber.Name = "colQRCodeNumber";
            this.colQRCodeNumber.ReadOnly = true;
            this.colQRCodeNumber.Width = 130;
            // 
            // ColProductName
            // 
            this.ColProductName.DataPropertyName = "Productname";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColProductName.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColProductName.HeaderText = "Tên sản phẩm";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            this.ColProductName.Width = 160;
            // 
            // ColWeight
            // 
            this.ColWeight.DataPropertyName = "Type";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColWeight.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColWeight.HeaderText = "Type";
            this.ColWeight.Name = "ColWeight";
            this.ColWeight.ReadOnly = true;
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(351, 17);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(75, 23);
            this.bntStop.TabIndex = 6;
            this.bntStop.Text = "&Stop";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.bntStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 565);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.bntStop);
            this.tabPage1.Controls.Add(this.cboDevice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1084, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(974, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Reset data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColqrCodeNumber1,
            this.ColproductName1,
            this.Coltype1,
            this.Colweight1,
            this.Colstats1,
            this.Coleitime1,
            this.Colstime1});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(943, 539);
            this.dataGridView2.TabIndex = 0;
            // 
            // ColqrCodeNumber1
            // 
            this.ColqrCodeNumber1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColqrCodeNumber1.DataPropertyName = "Number";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColqrCodeNumber1.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColqrCodeNumber1.HeaderText = "Mã code";
            this.ColqrCodeNumber1.Name = "ColqrCodeNumber1";
            this.ColqrCodeNumber1.ReadOnly = true;
            // 
            // ColproductName1
            // 
            this.ColproductName1.DataPropertyName = "productName";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColproductName1.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColproductName1.HeaderText = "Tên sản phẩm";
            this.ColproductName1.Name = "ColproductName1";
            this.ColproductName1.ReadOnly = true;
            this.ColproductName1.Width = 150;
            // 
            // Coltype1
            // 
            this.Coltype1.DataPropertyName = "type";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coltype1.DefaultCellStyle = dataGridViewCellStyle16;
            this.Coltype1.HeaderText = "Loại sản phẩm";
            this.Coltype1.Name = "Coltype1";
            this.Coltype1.ReadOnly = true;
            this.Coltype1.Width = 120;
            // 
            // Colweight1
            // 
            this.Colweight1.DataPropertyName = "weight";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Colweight1.DefaultCellStyle = dataGridViewCellStyle17;
            this.Colweight1.HeaderText = "Cân nặng";
            this.Colweight1.Name = "Colweight1";
            this.Colweight1.ReadOnly = true;
            this.Colweight1.Width = 90;
            // 
            // Colstats1
            // 
            this.Colstats1.DataPropertyName = "stats";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Colstats1.DefaultCellStyle = dataGridViewCellStyle18;
            this.Colstats1.HeaderText = "Tình trạng";
            this.Colstats1.Name = "Colstats1";
            this.Colstats1.ReadOnly = true;
            // 
            // Coleitime1
            // 
            this.Coleitime1.DataPropertyName = "eitime";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Coleitime1.DefaultCellStyle = dataGridViewCellStyle19;
            this.Coleitime1.HeaderText = "Thời gian";
            this.Coleitime1.Name = "Coleitime1";
            this.Coleitime1.ReadOnly = true;
            this.Coleitime1.Width = 170;
            // 
            // Colstime1
            // 
            this.Colstime1.DataPropertyName = "stime";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Colstime1.DefaultCellStyle = dataGridViewCellStyle20;
            this.Colstime1.HeaderText = "Lưu trữ";
            this.Colstime1.Name = "Colstime1";
            this.Colstime1.ReadOnly = true;
            this.Colstime1.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DataGridViewTextBoxColumn colQRCodeNumber;
        private DataGridViewTextBoxColumn ColProductName;
        private DataGridViewTextBoxColumn ColWeight;
        private DataGridViewTextBoxColumn ColqrCodeNumber1;
        private DataGridViewTextBoxColumn ColproductName1;
        private DataGridViewTextBoxColumn Coltype1;
        private DataGridViewTextBoxColumn Colweight1;
        private DataGridViewTextBoxColumn Colstats1;
        private DataGridViewTextBoxColumn Coleitime1;
        private DataGridViewTextBoxColumn Colstime1;
    }
}

