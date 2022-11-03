namespace S7_IIoT_Lamp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connect_btn = new System.Windows.Forms.Button();
            this.lb_cpustate = new System.Windows.Forms.Label();
            this.lb_scanmode = new System.Windows.Forms.Label();
            this.scan_mode = new System.Windows.Forms.Label();
            this.cpu_state = new System.Windows.Forms.Label();
            this.sbox_cpu = new System.Windows.Forms.ComboBox();
            this.sbox_scan = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_author = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_s3 = new System.Windows.Forms.RadioButton();
            this.rb_s2 = new System.Windows.Forms.RadioButton();
            this.rb_s1 = new System.Windows.Forms.RadioButton();
            this.panel_sim = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.background_sch = new System.Windows.Forms.PictureBox();
            this.s1 = new System.Windows.Forms.Button();
            this.s2 = new System.Windows.Forms.Button();
            this.s3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_sim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background_sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(202, 121);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(157, 37);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_event);
            // 
            // lb_cpustate
            // 
            this.lb_cpustate.AutoSize = true;
            this.lb_cpustate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpustate.Location = new System.Drawing.Point(28, 25);
            this.lb_cpustate.Name = "lb_cpustate";
            this.lb_cpustate.Size = new System.Drawing.Size(120, 29);
            this.lb_cpustate.TabIndex = 1;
            this.lb_cpustate.Text = "Cpu state:";
            // 
            // lb_scanmode
            // 
            this.lb_scanmode.AutoSize = true;
            this.lb_scanmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scanmode.Location = new System.Drawing.Point(28, 69);
            this.lb_scanmode.Name = "lb_scanmode";
            this.lb_scanmode.Size = new System.Drawing.Size(141, 29);
            this.lb_scanmode.TabIndex = 2;
            this.lb_scanmode.Text = "Scan mode:";
            // 
            // scan_mode
            // 
            this.scan_mode.AutoSize = true;
            this.scan_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_mode.Location = new System.Drawing.Point(218, 69);
            this.scan_mode.Name = "scan_mode";
            this.scan_mode.Size = new System.Drawing.Size(79, 29);
            this.scan_mode.TabIndex = 3;
            this.scan_mode.Text = "SCAN";
            // 
            // cpu_state
            // 
            this.cpu_state.AutoSize = true;
            this.cpu_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_state.Location = new System.Drawing.Point(218, 25);
            this.cpu_state.Name = "cpu_state";
            this.cpu_state.Size = new System.Drawing.Size(63, 29);
            this.cpu_state.TabIndex = 3;
            this.cpu_state.Text = "CPU";
            // 
            // sbox_cpu
            // 
            this.sbox_cpu.Enabled = false;
            this.sbox_cpu.FormattingEnabled = true;
            this.sbox_cpu.Items.AddRange(new object[] {
            "RUN_P",
            "RUN",
            "STOP"});
            this.sbox_cpu.Location = new System.Drawing.Point(33, 121);
            this.sbox_cpu.Name = "sbox_cpu";
            this.sbox_cpu.Size = new System.Drawing.Size(121, 37);
            this.sbox_cpu.TabIndex = 4;
            this.sbox_cpu.SelectedIndexChanged += new System.EventHandler(this.change_cpu_state);
            // 
            // sbox_scan
            // 
            this.sbox_scan.Enabled = false;
            this.sbox_scan.FormattingEnabled = true;
            this.sbox_scan.Items.AddRange(new object[] {
            "Single Scan",
            "Continuous Scan"});
            this.sbox_scan.Location = new System.Drawing.Point(33, 187);
            this.sbox_scan.Name = "sbox_scan";
            this.sbox_scan.Size = new System.Drawing.Size(121, 37);
            this.sbox_scan.TabIndex = 5;
            this.sbox_scan.SelectedIndexChanged += new System.EventHandler(this.change_scan_mode);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 393);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_author);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.connect_btn);
            this.tabPage1.Controls.Add(this.sbox_scan);
            this.tabPage1.Controls.Add(this.lb_cpustate);
            this.tabPage1.Controls.Add(this.sbox_cpu);
            this.tabPage1.Controls.Add(this.lb_scanmode);
            this.tabPage1.Controls.Add(this.cpu_state);
            this.tabPage1.Controls.Add(this.scan_mode);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(25);
            this.tabPage1.Size = new System.Drawing.Size(387, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.Location = new System.Drawing.Point(58, 323);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(264, 16);
            this.lb_author.TabIndex = 7;
            this.lb_author.Text = "Author: student Mykyta Poberezhnik, 555aM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_disc);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_s3);
            this.tabPage2.Controls.Add(this.rb_s2);
            this.tabPage2.Controls.Add(this.rb_s1);
            this.tabPage2.Controls.Add(this.panel_sim);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(15);
            this.tabPage2.Size = new System.Drawing.Size(387, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_s3
            // 
            this.rb_s3.AutoSize = true;
            this.rb_s3.Location = new System.Drawing.Point(238, 321);
            this.rb_s3.Name = "rb_s3";
            this.rb_s3.Size = new System.Drawing.Size(44, 20);
            this.rb_s3.TabIndex = 3;
            this.rb_s3.Text = "S3";
            this.rb_s3.UseVisualStyleBackColor = true;
            // 
            // rb_s2
            // 
            this.rb_s2.AutoSize = true;
            this.rb_s2.Location = new System.Drawing.Point(170, 321);
            this.rb_s2.Name = "rb_s2";
            this.rb_s2.Size = new System.Drawing.Size(44, 20);
            this.rb_s2.TabIndex = 2;
            this.rb_s2.Text = "S2";
            this.rb_s2.UseVisualStyleBackColor = true;
            // 
            // rb_s1
            // 
            this.rb_s1.AutoSize = true;
            this.rb_s1.Location = new System.Drawing.Point(89, 321);
            this.rb_s1.Name = "rb_s1";
            this.rb_s1.Size = new System.Drawing.Size(44, 20);
            this.rb_s1.TabIndex = 1;
            this.rb_s1.Text = "S1";
            this.rb_s1.UseVisualStyleBackColor = true;
            // 
            // panel_sim
            // 
            this.panel_sim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_sim.Controls.Add(this.pictureBox1);
            this.panel_sim.Controls.Add(this.s3);
            this.panel_sim.Controls.Add(this.s2);
            this.panel_sim.Controls.Add(this.s1);
            this.panel_sim.Controls.Add(this.background_sch);
            this.panel_sim.Location = new System.Drawing.Point(18, 18);
            this.panel_sim.Name = "panel_sim";
            this.panel_sim.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.panel_sim.Size = new System.Drawing.Size(351, 297);
            this.panel_sim.TabIndex = 0;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(163, 416);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(102, 16);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "Disconnected";
            // 
            // background_sch
            // 
            this.background_sch.Image = ((System.Drawing.Image)(resources.GetObject("background_sch.Image")));
            this.background_sch.Location = new System.Drawing.Point(0, 69);
            this.background_sch.Name = "background_sch";
            this.background_sch.Size = new System.Drawing.Size(350, 227);
            this.background_sch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_sch.TabIndex = 0;
            this.background_sch.TabStop = false;
            // 
            // s1
            // 
            this.s1.BackColor = System.Drawing.Color.White;
            this.s1.Enabled = false;
            this.s1.Location = new System.Drawing.Point(137, 231);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(75, 23);
            this.s1.TabIndex = 1;
            this.s1.UseVisualStyleBackColor = false;
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.Color.White;
            this.s2.Enabled = false;
            this.s2.Location = new System.Drawing.Point(85, 139);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(75, 23);
            this.s2.TabIndex = 2;
            this.s2.UseVisualStyleBackColor = false;
            // 
            // s3
            // 
            this.s3.BackColor = System.Drawing.Color.White;
            this.s3.Enabled = false;
            this.s3.Location = new System.Drawing.Point(188, 139);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(75, 23);
            this.s3.TabIndex = 3;
            this.s3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 441);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lamp S7 Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_sim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.background_sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label lb_cpustate;
        private System.Windows.Forms.Label lb_scanmode;
        private System.Windows.Forms.Label scan_mode;
        private System.Windows.Forms.Label cpu_state;
        private System.Windows.Forms.ComboBox sbox_cpu;
        private System.Windows.Forms.ComboBox sbox_scan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.RadioButton rb_s3;
        private System.Windows.Forms.RadioButton rb_s2;
        private System.Windows.Forms.RadioButton rb_s1;
        private System.Windows.Forms.Panel panel_sim;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Button s3;
        private System.Windows.Forms.Button s2;
        private System.Windows.Forms.Button s1;
        private System.Windows.Forms.PictureBox background_sch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

