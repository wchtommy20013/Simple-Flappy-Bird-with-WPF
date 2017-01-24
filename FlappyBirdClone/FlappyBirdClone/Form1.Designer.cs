namespace FlappyBirdClone {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GamingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.MainTimer_tick);
            // 
            // GamingPanel
            // 
            this.GamingPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GamingPanel.BackColor = System.Drawing.Color.Transparent;
            this.GamingPanel.Location = new System.Drawing.Point(12, 12);
            this.GamingPanel.Name = "GamingPanel";
            this.GamingPanel.Size = new System.Drawing.Size(492, 310);
            this.GamingPanel.TabIndex = 0;
            this.GamingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamingPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GamingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel GamingPanel;
        private System.Windows.Forms.Label label1;
    }
}

