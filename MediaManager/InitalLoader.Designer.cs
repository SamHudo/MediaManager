namespace MediaManager
{
    partial class InitalLoader
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
            this.components = new System.ComponentModel.Container();
            this.InitalProgressBar = new System.Windows.Forms.ProgressBar();
            this.Progresslbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // InitalProgressBar
            // 
            this.InitalProgressBar.Location = new System.Drawing.Point(12, 83);
            this.InitalProgressBar.Name = "InitalProgressBar";
            this.InitalProgressBar.Size = new System.Drawing.Size(776, 48);
            this.InitalProgressBar.TabIndex = 0;
            // 
            // Progresslbl
            // 
            this.Progresslbl.AutoSize = true;
            this.Progresslbl.Location = new System.Drawing.Point(12, 134);
            this.Progresslbl.Name = "Progresslbl";
            this.Progresslbl.Size = new System.Drawing.Size(28, 17);
            this.Progresslbl.TabIndex = 1;
            this.Progresslbl.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InitalLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 158);
            this.Controls.Add(this.Progresslbl);
            this.Controls.Add(this.InitalProgressBar);
            this.Name = "InitalLoader";
            this.Text = "Media Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar InitalProgressBar;
        private System.Windows.Forms.Label Progresslbl;
        private System.Windows.Forms.Timer timer1;
    }
}

