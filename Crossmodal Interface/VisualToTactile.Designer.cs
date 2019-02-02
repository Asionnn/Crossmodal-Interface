namespace Crossmodal_Interface
{
    partial class VisualToTactile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualToTactile));
            this.instr = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.redDot = new Crossmodal_Interface.TransparentPictureBox();
            this.transparentPictureBox1 = new Crossmodal_Interface.TransparentPictureBox();
            this.SuspendLayout();
            // 
            // instr
            // 
            this.instr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instr.AutoSize = true;
            this.instr.Location = new System.Drawing.Point(0, 0);
            this.instr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instr.Name = "instr";
            this.instr.Size = new System.Drawing.Size(35, 13);
            this.instr.TabIndex = 5;
            this.instr.Text = "label1";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(468, 271);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 32);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // redDot
            // 
            this.redDot.Image = ((System.Drawing.Image)(resources.GetObject("redDot.Image")));
            this.redDot.Location = new System.Drawing.Point(188, 86);
            this.redDot.Margin = new System.Windows.Forms.Padding(2);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(225, 244);
            this.redDot.TabIndex = 3;
            this.redDot.Text = "transparentPictureBox2";
            this.redDot.Click += new System.EventHandler(this.redDot_Click);
            // 
            // transparentPictureBox1
            // 
            this.transparentPictureBox1.Image = null;
            this.transparentPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.transparentPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.transparentPictureBox1.Name = "transparentPictureBox1";
            this.transparentPictureBox1.Size = new System.Drawing.Size(56, 19);
            this.transparentPictureBox1.TabIndex = 2;
            this.transparentPictureBox1.Text = "transparentPictureBox1";
            // 
            // VisualToTactile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.instr);
            this.Controls.Add(this.redDot);
            this.Controls.Add(this.transparentPictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisualToTactile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualToTactile";
            this.Load += new System.EventHandler(this.VisualToTactile_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VisualToTactile_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentPictureBox transparentPictureBox1;
        private TransparentPictureBox redDot;
        private System.Windows.Forms.Label instr;
        private System.Windows.Forms.Button submitBtn;
    }
}