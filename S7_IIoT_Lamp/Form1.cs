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
        myS7ProSimLib.S7ProSim sim = new myS7ProSimLib.S7ProSim();
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connect_event(object sender, EventArgs e)
        {
            //
            sim.Connect();
            cpu_state.Text = sim.GetState();
            scan_mode.Text = sim.GetScanMode().ToString();

            //
            sbox_cpu.Enabled = true;
            sbox_scan.Enabled = true;

            //
            lb_status.Text = "Connected";
            lb_status.BackColor = Color.Green;

            //
            rb_s1.Enabled = true;
            rb_s2.Enabled = true;
            rb_s3.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_disc(object sender, EventArgs e)
        {
            sim.Disconnect();

            //
            sbox_cpu.Enabled = false;
            sbox_scan.Enabled = false;

            //
            lb_status.Text = "Disconnected";
            lb_status.BackColor = Color.Red;

            //
            rb_s1.Enabled = false;
            rb_s2.Enabled = false;
            rb_s3.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_cpu_state(object sender, EventArgs e)
        {
            string selected = sbox_cpu.SelectedItem.ToString();
            try
            {
                sim.SetState(selected);
                cpu_state.Text = selected;
            }
            catch
            {
                MessageBox.Show("Unknown state selected");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_scan_mode(object sender, EventArgs e)
        {
            string selected = sbox_scan.SelectedItem.ToString();

            //
            if (selected == "Single Scan")
            {
                sim.SetScanMode(myS7ProSimLib.ScanModeConstants.SingleScan);
            }
            else if (selected == "Continuous Scan")
            {
                sim.SetScanMode(myS7ProSimLib.ScanModeConstants.ContinuousScan);
            }
            else
                MessageBox.Show("Unknown mode selected");

            scan_mode.Text = selected;
        }
    }
}
