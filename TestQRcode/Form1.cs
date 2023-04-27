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
using Microsoft.Office.Interop.Excel;
using ZXing;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestQRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
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
        private void StartCapturing()
        {
            if (captureDevice != null && !captureDevice.IsRunning)
            {
                captureDevice.Start();
                timer1.Start();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                StartCapturing();
                MessageBox.Show("Camera đã được kết nối!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối Camera: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntStop_Click(object sender, EventArgs e)
        {
            if (captureDevice != null)
            {
                captureDevice.Stop();
                captureDevice.NewFrame -= CaptureDevice_NewFrame;
                captureDevice = null;
                pictureBox1.Image = null;
            }
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap clonedBitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = clonedBitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Bitmap CropImage(Bitmap bitmap, System.Drawing.Rectangle cropArea)
        {
            Bitmap croppedBitmap = bitmap.Clone(cropArea, bitmap.PixelFormat);
            return croppedBitmap;
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

            private string type;
            public string Type { get => type; set => type = value; }

            private string weight;
            public string Weight { get => weight; set => weight = value; }

            private string stats;
            public string Stats { get => stats; set => stats = value; }

            private string eitime;
            public string Eitime { get => eitime; set => eitime = value; }

            private string stime;
            public string Stime { get => stime; set => stime = value; }

            public ThongtinQR(string number, string productname, string type, string weight, string stats, string eitime, string stime)
            {
                Number = number;
                Productname = productname;
                Type = type;
                Weight = weight;
                Stats = stats;
                Eitime = eitime;
                Stime = stime;
            }


        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo ứng dụng Excel và Workbook mới
            Excel.Application excel = new Excel.Application();
            Workbook workbook = excel.Workbooks.Add();

            // Lấy Worksheet đầu tiên trong Workbook
            Worksheet worksheet = workbook.ActiveSheet;

            // Thêm header
            worksheet.Cells[1, "A"].Value = "Mã Code";
            worksheet.Cells[1, "B"].Value = "Tên sản phẩm";
            worksheet.Cells[1, "C"].Value = "Thể loại";
            worksheet.Cells[1, "D"].Value = "Cân nặng";
            worksheet.Cells[1, "E"].Value = "Trạng thái";
            worksheet.Cells[1, "F"].Value = "Thời gian";
            worksheet.Cells[1, "G"].Value = "Lưu trữ";
            Range headerRange = worksheet.Range["A1:G1"];
            headerRange.Font.Bold = true;
            headerRange.Font.Color = Color.Green;

            // Ghi dữ liệu vào các ô
            int row = 3;
            foreach (ThongtinQR qr in listQR)
            {
                worksheet.Cells[row, "A"].Value = qr.Number;
                worksheet.Cells[row, "B"].Value = qr.Productname;
                worksheet.Cells[row, "C"].Value = qr.Type;
                worksheet.Cells[row, "D"].Value = qr.Weight;
                worksheet.Cells[row, "E"].Value = qr.Stats;
                worksheet.Cells[row, "F"].Value = qr.Eitime;
                worksheet.Cells[row, "G"].Value = qr.Stime;
                row++;
                worksheet.Columns.AutoFit();
            }

            // Hiển thị hộp thoại lưu file để cho phép người dùng chọn đường dẫn và tên file lưu trữ
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.ShowDialog();

            // Nếu người dùng đã chọn đường dẫn và tên file lưu trữ
            if (saveFileDialog.FileName != "")
            {
                // Lưu Workbook vào đường dẫn và tên file lưu trữ được chọn
                workbook.SaveAs(saveFileDialog.FileName);

                // Hiển thị thông báo lưu file thành công
                MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Đóng Workbook và Excel Application
            workbook.Close();
            excel.Quit();
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    string[] fields = result.Text.Split(';');
                    if (fields.Length >= 7)
                    {
                        string number = fields[0];
                        string productName = fields[1];
                        string type = fields[2];
                        string weight = fields[3];
                        string stats = fields[4];
                        string eitime = fields[5];
                        string stime = fields[6];
                        ThongtinQR qr = new ThongtinQR(number, productName, type, weight, stats, eitime, stime);
                        listQR.Add(qr);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listQR;

                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = listQR;
                    }
                    else
                    {
                        if (captureDevice.IsRunning)
                            captureDevice.Stop();
                        MessageBox.Show("Thông tin thùng hàng bị thiếu, hãy kiểm tra lại");
                    }

                    await Task.Delay(5000);
                    StartCapturing();
                }
            }

        }

    }
}
