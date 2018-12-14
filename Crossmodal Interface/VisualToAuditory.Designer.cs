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
            this.exitBtn = new System.Windows.Forms.Button();
            this.instr = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.redDot = new Crossmodal_Interface.TransparentPictureBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(0, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 40);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // instr
            // 
            this.instr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instr.AutoSize = true;
            this.instr.Location = new System.Drawing.Point(0, 0);
            this.instr.Name = "instr";
            this.instr.Size = new System.Drawing.Size(38, 17);
            this.instr.TabIndex = 4;
            this.instr.Text = "hello";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(688, 381);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(100, 40);
            this.finishBtn.TabIndex = 5;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // redDot
            // 
            this.redDot.Image = ((System.Drawing.Image)(resources.GetObject("redDot.Image")));
            this.redDot.Location = new System.Drawing.Point(328, 127);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(300, 300);
            this.redDot.TabIndex = 3;
            this.redDot.Text = "transparentPictureBox1";
            // 
            // VisualToAuditory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.instr);
            this.Controls.Add(this.redDot);
            this.Controls.Add(this.exitBtn);
            this.KeyPreview = true;
            this.Name = "VisualToAuditory";
            this.Text = "VisualToAuditory";
            this.Load += new System.EventHandler(this.VisualToAuditory_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VisualToAuditory_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private TransparentPictureBox redDot;
        private System.Windows.Forms.Label instr;
        private System.Windows.Forms.Button finishBtn;
    }
}