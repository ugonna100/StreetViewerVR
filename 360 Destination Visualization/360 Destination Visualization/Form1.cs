using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _360_Destination_Visualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = @"C:\Python27\python.exe";
                pythonInfo.Arguments = string.Format(@"C:\Users\pspyt\source\repos\360 Destination Visualization\360 Destination Visualization\Resources\main.py");
                pythonInfo.CreateNoWindow = false;
                pythonInfo.UseShellExecute = false;
                pythonInfo.RedirectStandardOutput = true;

            Console.WriteLine("Python Starting");
                python = Process.Start(pythonInfo);
                python.WaitForExit();
                python.Close();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FromText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ToText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
