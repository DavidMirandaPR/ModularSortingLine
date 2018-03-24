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
        ArduinoController arduinoController = new ArduinoController();
        string[] colors = new string[] { "<select>", "RED", "BLUE", "GREEN" };
        string[] shapes = new string[] { "<select>", "SQUARE", "CUBE", "TRIANGLE" };


        public CapstoneFormApp()
        {
            InitializeComponent();
            this.ColorsDropDown.DataSource = colors;
            this.ShapesDropDown.DataSource = shapes;
        }

        private void CapstoneFormApp_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LEDOn_Click(object sender, EventArgs e)
        {
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("HIGH", 3);
        }

        private void LedOff_Btn_Click(object sender, EventArgs e)
        {
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("LOW", 3);

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

        

        private void Btn_CMDTest_Click(object sender, EventArgs e)
        {
            CommandController cmdController = new CommandController();
            //cmdController.ExecutePythonScript("test");
            cmdController.ExecutePythonScriptFromCMD("shapeRecognition", this);
        }

        private void ShapeDetectedLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenDoorOne_Btn_Click(object sender, EventArgs e)
        {
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("DOOR", 1);
        }

        private void CloseDoorOne_Btn_Click(object sender, EventArgs e)
        {
            arduinoController.SetComPort();
            arduinoController.SendCommandToPin("DOOR", 2);
        }
    }
}
