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
            this.connect_btn = new System.Windows.Forms.Button();
            this.lb_cpustate = new System.Windows.Forms.Label();
            this.lb_scanmode = new System.Windows.Forms.Label();
            this.scan_mode = new System.Windows.Forms.Label();
            this.cpu_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(331, 34);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_event);
            // 
            // lb_cpustate
            // 
            this.lb_cpustate.AutoSize = true;
            this.lb_cpustate.Location = new System.Drawing.Point(166, 112);
            this.lb_cpustate.Name = "lb_cpustate";
            this.lb_cpustate.Size = new System.Drawing.Size(66, 16);
            this.lb_cpustate.TabIndex = 1;
            this.lb_cpustate.Text = "Cpu state:";
            // 
            // lb_scanmode
            // 
            this.lb_scanmode.AutoSize = true;
            this.lb_scanmode.Location = new System.Drawing.Point(166, 158);
            this.lb_scanmode.Name = "lb_scanmode";
            this.lb_scanmode.Size = new System.Drawing.Size(79, 16);
            this.lb_scanmode.TabIndex = 2;
            this.lb_scanmode.Text = "Scan mode:";
            // 
            // scan_mode
            // 
            this.scan_mode.AutoSize = true;
            this.scan_mode.Location = new System.Drawing.Point(258, 158);
            this.scan_mode.Name = "scan_mode";
            this.scan_mode.Size = new System.Drawing.Size(0, 16);
            this.scan_mode.TabIndex = 3;
            // 
            // cpu_state
            // 
            this.cpu_state.AutoSize = true;
            this.cpu_state.Location = new System.Drawing.Point(258, 112);
            this.cpu_state.Name = "cpu_state";
            this.cpu_state.Size = new System.Drawing.Size(0, 16);
            this.cpu_state.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.cpu_state);
            this.Controls.Add(this.scan_mode);
            this.Controls.Add(this.lb_scanmode);
            this.Controls.Add(this.lb_cpustate);
            this.Controls.Add(this.connect_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label lb_cpustate;
        private System.Windows.Forms.Label lb_scanmode;
        private System.Windows.Forms.Label scan_mode;
        private System.Windows.Forms.Label cpu_state;
    }
}

