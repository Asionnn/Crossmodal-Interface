namespace Crossmodal_Interface
{
    partial class AuditoryToVisual
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
            this.redDot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).BeginInit();
            this.SuspendLayout();
            // 
            // redDot
            // 
            this.redDot.Image = global::Crossmodal_Interface.Properties.Resources.Circle;
            this.redDot.Location = new System.Drawing.Point(355, 154);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(100, 100);
            this.redDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redDot.TabIndex = 0;
            this.redDot.TabStop = false;
            // 
            // AuditoryToVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redDot);
            this.Name = "AuditoryToVisual";
            this.Text = "AuditoryToVisual";
            this.Load += new System.EventHandler(this.AuditoryToVisual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redDot;
    }
}