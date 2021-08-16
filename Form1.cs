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

            foreach (ManagementObject videoObj in myVideoObject.Get())
            {
                Console.WriteLine(videoObj["Name"]);
                Console.WriteLine(videoObj["DriverVersion"]);
                lblName.Text = videoObj["Name"].ToString();
                lblDrivers.Text = videoObj["DriverVersion"].ToString();
            }
            foreach (ManagementObject item in myProcessorObject.Get())
            {
                Console.WriteLine(item.ToString());
                var x = item.ToString();
                Console.WriteLine(item[x].ToString());
                
            }
        }
    }
}


