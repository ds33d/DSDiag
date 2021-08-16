using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace DSDiag
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.MinimumSize = new Size(545, 296);
            this.MaximumSize = new Size(545, 296);
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {



            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectSearcher myMemoryObject = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
           

            foreach (ManagementObject videoObj in myVideoObject.Get())
            {
                Console.WriteLine(videoObj["Name"]);
                Console.WriteLine(videoObj["DriverVersion"]);
                lblName.Text = videoObj["Name"].ToString();
                lblDrivers.Text = videoObj["DriverVersion"].ToString();
            }
            foreach (ManagementObject item in myProcessorObject.Get())
            {
                lblProccessor.Text = item["Name"].ToString();
                lblSysName.Text = item["SystemName"].ToString();


            }
            var num = 0;
            foreach (ManagementObject item in myMemoryObject.Get())
            {
                num++;
                var x = item["Capacity"].ToString();
                var y = Convert.ToDouble(x) / 1000000;
                y = Convert.ToInt32(y);

                y = y * num;
                Console.WriteLine(y);
                lblPhysMemory.Text = "RAM: " + y.ToString() + "MB";


            }
        }
    }
}


