﻿using System;
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
        ArduinoController arduinoController = new ArduinoController();
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
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("HIGH",3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            arduinoController.ports = ArduinoController.GetPorts();
            if (arduinoController.ports != null)
                ComPortsDropDown.DataSource = arduinoController.ports;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LedOff_Btn_Click(object sender, EventArgs e)
        {
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("LOW", 3);
        }
    }
}
