namespace Crossmodal_Interface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.visual = new System.Windows.Forms.PictureBox();
            this.auditory = new System.Windows.Forms.PictureBox();
            this.newUser = new System.Windows.Forms.Button();
            this.setValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // visual
            // 
            this.visual.ErrorImage = null;
            this.visual.Image = ((System.Drawing.Image)(resources.GetObject("visual.Image")));
            this.visual.InitialImage = null;
            this.visual.Location = new System.Drawing.Point(290, 155);
            this.visual.Name = "visual";
            this.visual.Size = new System.Drawing.Size(117, 116);
            this.visual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visual.TabIndex = 2;
            this.visual.TabStop = false;
            // 
            // auditory
            // 
            this.auditory.Image = global::Crossmodal_Interface.Properties.Resources.auditory;
            this.auditory.Location = new System.Drawing.Point(463, 155);
            this.auditory.Name = "auditory";
            this.auditory.Size = new System.Drawing.Size(160, 116);
            this.auditory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auditory.TabIndex = 3;
            this.auditory.TabStop = false;
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(12, 504);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(90, 31);
            this.newUser.TabIndex = 4;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // setValue
            // 
            this.setValue.BackColor = System.Drawing.Color.Red;
            this.setValue.Location = new System.Drawing.Point(600, 491);
            this.setValue.Name = "setValue";
            this.setValue.Size = new System.Drawing.Size(143, 44);
            this.setValue.TabIndex = 5;
            this.setValue.Text = "Set";
            this.setValue.UseVisualStyleBackColor = false;
            this.setValue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.setValue);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.auditory);
            this.Controls.Add(this.visual);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Crossmodal Matching";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox visual;
        private System.Windows.Forms.PictureBox auditory;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button setValue;
    }
}

