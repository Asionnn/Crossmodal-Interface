namespace Crossmodal_Interface
{
    partial class VisualToAuditory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualToAuditory));
            this.redDot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).BeginInit();
            this.SuspendLayout();
            // 
            // redDot
            // 
            this.redDot.Image = ((System.Drawing.Image)(resources.GetObject("redDot.Image")));
            this.redDot.Location = new System.Drawing.Point(493, 193);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(100, 100);
            this.redDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redDot.TabIndex = 0;
            this.redDot.TabStop = false;
            // 
            // VisualToAuditory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.redDot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualToAuditory";
            this.Text = "VisualToAuditory";
            this.Load += new System.EventHandler(this.VisualToAuditory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redDot;
    }
}