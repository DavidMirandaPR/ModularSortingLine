using System.Windows.Forms;

namespace InterCapstone.FormApp
{
    partial class CapstoneFormApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.Btn_CMDTest = new System.Windows.Forms.Button();
            this.Btn_GetPorts = new System.Windows.Forms.Button();
            this.ComPortsDropDown = new System.Windows.Forms.ComboBox();
            this.Btn_LEDOff = new System.Windows.Forms.Button();
            this.Btn_LEDOn = new System.Windows.Forms.Button();
            this.ShapeDetectedLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(763, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fIleToolStripMenuItem.Text = "File";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.ShapeDetectedLabel);
            this.DashboardPanel.Controls.Add(this.Btn_CMDTest);
            this.DashboardPanel.Controls.Add(this.Btn_GetPorts);
            this.DashboardPanel.Controls.Add(this.ComPortsDropDown);
            this.DashboardPanel.Controls.Add(this.Btn_LEDOff);
            this.DashboardPanel.Controls.Add(this.Btn_LEDOn);
            this.DashboardPanel.Location = new System.Drawing.Point(0, 31);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(763, 461);
            this.DashboardPanel.TabIndex = 1;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_CMDTest
            // 
            this.Btn_CMDTest.Location = new System.Drawing.Point(261, 28);
            this.Btn_CMDTest.Name = "Btn_CMDTest";
            this.Btn_CMDTest.Size = new System.Drawing.Size(142, 23);
            this.Btn_CMDTest.TabIndex = 4;
            this.Btn_CMDTest.Text = "Test CMD";
            this.Btn_CMDTest.UseVisualStyleBackColor = true;
            this.Btn_CMDTest.Click += new System.EventHandler(this.Btn_CMDTest_Click);
            // 
            // Btn_GetPorts
            // 
            this.Btn_GetPorts.Location = new System.Drawing.Point(139, 28);
            this.Btn_GetPorts.Name = "Btn_GetPorts";
            this.Btn_GetPorts.Size = new System.Drawing.Size(95, 23);
            this.Btn_GetPorts.TabIndex = 3;
            this.Btn_GetPorts.Text = "Get Ports";
            this.Btn_GetPorts.UseVisualStyleBackColor = true;
            this.Btn_GetPorts.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ComPortsDropDown
            // 
            this.ComPortsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortsDropDown.FormattingEnabled = true;
            this.ComPortsDropDown.Location = new System.Drawing.Point(12, 27);
            this.ComPortsDropDown.Name = "ComPortsDropDown";
            this.ComPortsDropDown.Size = new System.Drawing.Size(121, 24);
            this.ComPortsDropDown.TabIndex = 2;
            // 
            // Btn_LEDOff
            // 
            this.Btn_LEDOff.Location = new System.Drawing.Point(12, 72);
            this.Btn_LEDOff.Name = "Btn_LEDOff";
            this.Btn_LEDOff.Size = new System.Drawing.Size(110, 23);
            this.Btn_LEDOff.TabIndex = 1;
            this.Btn_LEDOff.Text = "LED OFF";
            this.Btn_LEDOff.UseVisualStyleBackColor = true;
            this.Btn_LEDOff.Click += new System.EventHandler(this.LedOff_Btn_Click);
            // 
            // Btn_LEDOn
            // 
            this.Btn_LEDOn.Location = new System.Drawing.Point(139, 72);
            this.Btn_LEDOn.Name = "Btn_LEDOn";
            this.Btn_LEDOn.Size = new System.Drawing.Size(75, 23);
            this.Btn_LEDOn.TabIndex = 0;
            this.Btn_LEDOn.Text = "LED ON";
            this.Btn_LEDOn.UseVisualStyleBackColor = true;
            this.Btn_LEDOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShapeDetectedLabel
            // 
            this.ShapeDetectedLabel.AutoSize = true;
            this.ShapeDetectedLabel.Location = new System.Drawing.Point(356, 132);
            this.ShapeDetectedLabel.Name = "ShapeDetectedLabel";
            this.ShapeDetectedLabel.Size = new System.Drawing.Size(114, 17);
            this.ShapeDetectedLabel.TabIndex = 5;
            this.ShapeDetectedLabel.Text = "Shape Detected:";
            this.ShapeDetectedLabel.Click += new System.EventHandler(this.ShapeDetectedLabel_Click);
            // 
            // CapstoneFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 492);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "CapstoneFormApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CapstoneFormApp_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.Button Btn_LEDOn;
        private System.Windows.Forms.Button Btn_LEDOff;
        private System.Windows.Forms.Button Btn_GetPorts;
        private System.Windows.Forms.ComboBox ComPortsDropDown;
        private Button Btn_CMDTest;
        public Label ShapeDetectedLabel;
    }
}

