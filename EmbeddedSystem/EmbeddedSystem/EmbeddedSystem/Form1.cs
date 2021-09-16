using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Thu vien SerialPort
using System.IO.Ports;
using System.IO;
using System.Xml;


namespace EmbeddedSystem
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.

        public Form1()
        {
            InitializeComponent();
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox3.Items.AddRange(BaudRate);
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
           
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("C");
            }    
        }

        private void btnFanOn_Click(object sender, EventArgs e)
        {
            
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("E");
            }
        }

        private void btnFanOff_Click(object sender, EventArgs e)
        {
            
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("F");
            }
        }

        private void btnLightOff_Click(object sender, EventArgs e)
        {
            
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("D");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox4.DataSource = SerialPort.GetPortNames();//Quét các cổng Serial đang hoạt động lên ComboBox1
            comboBox3.SelectedItem = "9600";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen) // Nếu đối tượng serialPort1 chưa được mở , sau khi nhấn button 1 thỳ…
            {

                //cổng serialPort1 = ComboBox mà bạn đang chọn
                // serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort2.PortName = comboBox4.Text;
                serialPort2.BaudRate = 9600;
                serialPort2.Open();// Mở cổng serialPort1

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {

                label7.Text = ("Chưa kết nối");
                label7.ForeColor = Color.Red;
            }
            else if (serialPort2.IsOpen)
            {

                label7.Text = ("Đã kết nối");
                label7.ForeColor = Color.Green;

            }
        }

    }
}
