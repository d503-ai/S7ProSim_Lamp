using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myS7ProSimLib;

namespace S7_IIoT_Lamp
{
    public partial class Form1 : Form
    {
        //
        private myS7ProSimLib.S7ProSim sim = new myS7ProSimLib.S7ProSim();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_event(object sender, EventArgs e)
        {
            //
            sim.Connect();
            cpu_state.Text = sim.GetState();
            scan_mode.Text = sim.GetScanMode().ToString();

            //
            sbox_cpu.IsEnabled = true;
            sbox_state.IsEnabled = true;
        }
    }
}
