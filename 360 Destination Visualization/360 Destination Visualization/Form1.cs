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
        public String pythonPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                pythonPath = PDirectory.Text;
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = @""+ pythonPath;
                pythonInfo.Arguments = string.Format(@"C:\PythonFiles\main.py {0} {1}", FromText.Text,ToText.Text);
                pythonInfo.CreateNoWindow = false;
                pythonInfo.UseShellExecute = false;
                

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

        private void Set_Click(object sender, EventArgs e)
        {
            pythonPath = PDirectory.Text;
        }

        private void PDirectory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}