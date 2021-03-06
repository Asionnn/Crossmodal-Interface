﻿namespace Crossmodal_Interface
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
            this.instr = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.redDot = new Crossmodal_Interface.TransparentPictureBox();
            this.SuspendLayout();
            // 
            // instr
            // 
            this.instr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instr.AutoSize = true;
            this.instr.Location = new System.Drawing.Point(0, 0);
            this.instr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instr.Name = "instr";
            this.instr.Size = new System.Drawing.Size(29, 13);
            this.instr.TabIndex = 4;
            this.instr.Text = "hello";
            this.instr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(312, 119);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 32);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.Submit_Click);
            // 
            // redDot
            // 
            this.redDot.Image = ((System.Drawing.Image)(resources.GetObject("redDot.Image")));
            this.redDot.Location = new System.Drawing.Point(246, 103);
            this.redDot.Margin = new System.Windows.Forms.Padding(2);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(225, 244);
            this.redDot.TabIndex = 3;
            this.redDot.Text = "transparentPictureBox1";
            // 
            // VisualToAuditory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.instr);
            this.Controls.Add(this.redDot);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisualToAuditory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualToAuditory";
            this.Load += new System.EventHandler(this.VisualToAuditory_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VisualToAuditory_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentPictureBox redDot;
        private System.Windows.Forms.Label instr;
        private System.Windows.Forms.Button submitBtn;
    }
}