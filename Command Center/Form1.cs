using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Command_Center
{
    public partial class Form1 : Form
    {

        PerformanceCounter cpuCounter;
            PerformanceCounter ramCounter;

            
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clock.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PerformanceCounter cpuCounter;
            PerformanceCounter ramCounter;
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");


            //Converting some values
            int cpuvalue = (int)Math.Ceiling(cpuCounter.NextValue());

            CPU.Value = cpuvalue;
            metroButton1.Text = cpuvalue.ToString();
        }
    }
}
