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
        // Library that allows to connect to the Simatic program
        myS7ProSimLib.S7ProSim sim = new myS7ProSimLib.S7ProSim();
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializing after connecting
        /// </summary>
        private void on_all()
        {
            // Enable checkboxes
            sbox_cpu.Enabled = true;
            sbox_scan.Enabled = true;

            // Enable checkbuttons
            rb_s1.Enabled = true;
            rb_s2.Enabled = true;
            rb_s3.Enabled = true;
        }

        /// <summary>
        /// Reset settings
        /// </summary>
        private void off_all()
        {
            // Clear content of labels
            sbox_cpu.Text = "";
            sbox_scan.Text = "";
            cpu_state.Text = "";
            scan_mode.Text = "";

            // Disable checkbuttons
            rb_s1.Enabled = false;
            rb_s2.Enabled = false;
            rb_s3.Enabled = false;


            // Disable state and mode boxes
            sbox_cpu.Enabled = false;
            sbox_scan.Enabled = false;

            // Disable lamp
            picture_lamp.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Connection to simatic program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connect_event(object sender, EventArgs e)
        {
            // Connection, getting data from currect CPU state and Scan mode
            sim.Connect();
            cpu_state.Text = sim.GetState();
            scan_mode.Text = sim.GetScanMode().ToString();



            // Change labels
            lb_status.Text = "Connected";
            lb_status.ForeColor = Color.Green;
                
            on_all();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_disc(object sender, EventArgs e)
        {
            // Disconnect
            sim.Disconnect();

            // Change labels
            lb_status.Text = "Disconnected";
            lb_status.ForeColor = Color.Red;

            off_all();
        }

        /// <summary>
        /// Changing CPU state, writing data from S7 Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_cpu_state(object sender, EventArgs e)
        {
            // Read selected CPU state 
            string selected = sbox_cpu.SelectedItem.ToString();
            
            // Try to change CPU state to the selected one
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
        /// Changing scan mode, writing data from S7 program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_scan_mode(object sender, EventArgs e)
        {
            // Read selected scan mode
            string selected = sbox_scan.SelectedItem.ToString();

            // Change scan mode to the selected one
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

        /// <summary>
        /// Change state of S1(I0.0) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S1_check(object sender, EventArgs e)
        {
            //Read S1 state
            object I0_0 = rb_s1.Checked;

            //Write state to the I0.0 in S7 Program
            sim.WriteInputPoint(0, 0, ref I0_0);

            // If selected CPU state is correct, visualize work on the scheme
            if((sim.GetState() == "RUN" || sim.GetState() == "RUN_P") && Convert.ToBoolean(I0_0) == true)
            {
                s1.BackColor = Color.Green;
            }
            else
            {
                s1.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Change state of S2(I0.1) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S2_check(object sender, EventArgs e)
        {
            // Read S2 state
            object I0_1 = rb_s2.Checked;

            // Write state to the I0.1 in S7 Program
            sim.WriteInputPoint(0, 1, ref I0_1);

            // If selected CPU state is correct, visualize work on the scheme
            if ((sim.GetState() == "RUN" || sim.GetState() == "RUN_P") && Convert.ToBoolean(I0_1) == true)
            {
                s2.BackColor = Color.Green;
            }
            else
            {
                s2.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Change state of S3 (I0.2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S3_check(object sender, EventArgs e)
        {
            // Read S3 state
            object I0_2 = rb_s3.Checked;

            // Write state to the I0.1 in S7 Program
            sim.WriteInputPoint(0, 2, ref I0_2);

            // If selected CPU state is correct, visualize work on the scheme
            if ((sim.GetState() == "RUN" || sim.GetState() == "RUN_P") && Convert.ToBoolean(I0_2) == true)
            {
                s3.BackColor = Color.Green;
            }
            else
            {
                s3.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Changing state of the lamp. Timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lamp_check(object sender, EventArgs e)
        {
            // Write initial state of lamp
            object Q0_0 = false;

            // Read output signal of the lamp
            sim.ReadOutputPoint(0, 0, myS7ProSimLib.PointDataTypeConstants.S7_Bit, ref Q0_0);

            // Ternar operator: visualize changing of the lamp's state, depending on signal
            picture_lamp.BackColor = (bool)Q0_0 ? Color.Yellow : Color.Transparent;
        }
    }
}
