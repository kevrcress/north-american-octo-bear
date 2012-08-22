namespace ProductivityTimer
{
    partial class frmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTimerType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxTimer = new System.Windows.Forms.GroupBox();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbxTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(13, 55);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(68, 23);
            this.btnStartTimer.TabIndex = 0;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(87, 55);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(68, 23);
            this.btnStopTimer.TabIndex = 1;
            this.btnStopTimer.Text = "Pause Timer";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Location = new System.Drawing.Point(161, 55);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.Size = new System.Drawing.Size(68, 23);
            this.btnResetTimer.TabIndex = 2;
            this.btnResetTimer.Text = "Reset Timer";
            this.btnResetTimer.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(572, 434);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 3;
            // 
            // lblTimerType
            // 
            this.lblTimerType.AutoSize = true;
            this.lblTimerType.Location = new System.Drawing.Point(6, 26);
            this.lblTimerType.Name = "lblTimerType";
            this.lblTimerType.Size = new System.Drawing.Size(75, 13);
            this.lblTimerType.TabIndex = 4;
            this.lblTimerType.Text = "Set timer for a ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Productivity Timer";
            // 
            // grbxTimer
            // 
            this.grbxTimer.Controls.Add(this.lblTimerText);
            this.grbxTimer.Controls.Add(this.comboBox1);
            this.grbxTimer.Controls.Add(this.btnResetTimer);
            this.grbxTimer.Controls.Add(this.btnStartTimer);
            this.grbxTimer.Controls.Add(this.lblTimerType);
            this.grbxTimer.Controls.Add(this.btnStopTimer);
            this.grbxTimer.Location = new System.Drawing.Point(20, 89);
            this.grbxTimer.Name = "grbxTimer";
            this.grbxTimer.Size = new System.Drawing.Size(250, 228);
            this.grbxTimer.TabIndex = 6;
            this.grbxTimer.TabStop = false;
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.Location = new System.Drawing.Point(27, 95);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(182, 42);
            this.lblTimerText.TabIndex = 6;
            this.lblTimerText.Text = "00:00:00";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "task",
            "short break",
            "long break"});
            this.comboBox1.Location = new System.Drawing.Point(87, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProductivityTimer.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.grbxTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 495);
            this.MinimumSize = new System.Drawing.Size(700, 495);
            this.Name = "frmTimer";
            this.Text = "Productivity Timer";
            this.grbxTimer.ResumeLayout(false);
            this.grbxTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnResetTimer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTimerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxTimer;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label lblTimerText;
    }
}

