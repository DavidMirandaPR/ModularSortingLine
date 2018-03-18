using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterCapstone.FormApp;


namespace InterCapstone.FormApp
{
    public partial class CapstoneFormApp : Form
    {
        public string[] ports;

        public CapstoneFormApp()
        {
            InitializeComponent();
        }

        private void CapstoneFormApp_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ports = ArduinoController.GetPorts();
            if (ports != null)
                ComPortsDropDown.DataSource = this.ports;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
