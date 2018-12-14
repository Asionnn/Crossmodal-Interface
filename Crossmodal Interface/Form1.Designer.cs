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
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeText = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.VT = new System.Windows.Forms.Button();
            this.VA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // welcomeText
            // 
            this.welcomeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeText.Location = new System.Drawing.Point(0, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(1007, 109);
            this.welcomeText.TabIndex = 7;
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(413, 143);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(180, 22);
            this.nameInput.TabIndex = 8;
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown_1);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(361, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // VT
            // 
            this.VT.Location = new System.Drawing.Point(343, 231);
            this.VT.Name = "VT";
            this.VT.Size = new System.Drawing.Size(100, 100);
            this.VT.TabIndex = 10;
            this.VT.Text = "V-T";
            this.VT.UseVisualStyleBackColor = true;
            this.VT.Click += new System.EventHandler(this.VT_Click_1);
            // 
            // VA
            // 
            this.VA.Location = new System.Drawing.Point(555, 231);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(100, 100);
            this.VA.TabIndex = 11;
            this.VA.Text = "V-A";
            this.VA.UseVisualStyleBackColor = true;
            this.VA.Click += new System.EventHandler(this.VA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1007, 673);
            this.Controls.Add(this.VA);
            this.Controls.Add(this.VT);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button VT;
        private System.Windows.Forms.Button VA;
    }
}

