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
            this.InitalProgressBar = new System.Windows.Forms.ProgressBar();
            this.Progresslbl = new System.Windows.Forms.Label();
            this.BackboneWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // InitalProgressBar
            // 
            this.InitalProgressBar.Location = new System.Drawing.Point(12, 12);
            this.InitalProgressBar.Name = "InitalProgressBar";
            this.InitalProgressBar.Size = new System.Drawing.Size(776, 48);
            this.InitalProgressBar.TabIndex = 0;
            // 
            // Progresslbl
            // 
            this.Progresslbl.AutoSize = true;
            this.Progresslbl.Location = new System.Drawing.Point(12, 63);
            this.Progresslbl.Name = "Progresslbl";
            this.Progresslbl.Size = new System.Drawing.Size(28, 17);
            this.Progresslbl.TabIndex = 1;
            this.Progresslbl.Text = "0%";
            // 
            // BackboneWorker
            // 
            this.BackboneWorker.WorkerReportsProgress = true;
            this.BackboneWorker.WorkerSupportsCancellation = true;
            this.BackboneWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackboneWorker_DoWork);
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
        public System.ComponentModel.BackgroundWorker BackboneWorker;
    }
}

