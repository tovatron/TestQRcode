using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace TestQRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        List<ThongtinQR> listQR = new List<ThongtinQR>();

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

        }
        public class ThongtinQR
        {
            private string number;
            public string Number { get => number; set => number = value; }

            private string productname;
            public string Productname { get => productname; set => productname = value; }

            private string weight;
            public string Weight { get => weight; set => weight = value; }

            public ThongtinQR(string number, string productname, string weight)
            {
                Number = number;
                Productname = productname;
                Weight = weight;
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txtQRCode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    string[] fields = result.Text.Split(';');
                    if (fields.Length >= 3)
                    {
                        string qrCodeNumber = fields[0];
                        string productName = fields[1];
                        string weight = fields[2];
                        ThongtinQR qr = new ThongtinQR(qrCodeNumber, productName, weight);
                        listQR.Add(qr);
                        dataGridView1.DataSource = listQR;
                    }
                }
            }

        }

    }
}
