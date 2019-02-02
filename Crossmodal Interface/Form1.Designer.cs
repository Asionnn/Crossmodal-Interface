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
            this.results = new System.Windows.Forms.Label();
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
            // welcomeText
            // 
            this.welcomeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeText.Location = new System.Drawing.Point(0, 0);
            this.welcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(755, 89);
            this.welcomeText.TabIndex = 7;
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(500, 0);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(136, 20);
            this.nameInput.TabIndex = 8;
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown_1);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(500, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // VT
            // 
            this.VT.Location = new System.Drawing.Point(257, 188);
            this.VT.Margin = new System.Windows.Forms.Padding(2);
            this.VT.Name = "VT";
            this.VT.Size = new System.Drawing.Size(75, 81);
            this.VT.TabIndex = 10;
            this.VT.Text = "V-T";
            this.VT.UseVisualStyleBackColor = true;
            this.VT.Click += new System.EventHandler(this.VT_Click_1);
            // 
            // VA
            // 
            this.VA.Location = new System.Drawing.Point(416, 188);
            this.VA.Margin = new System.Windows.Forms.Padding(2);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(75, 81);
            this.VA.TabIndex = 11;
            this.VA.Text = "V-A";
            this.VA.UseVisualStyleBackColor = true;
            this.VA.Click += new System.EventHandler(this.VA_Click);
            // 
            // results
            // 
            this.results.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(380, 73);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 13);
            this.results.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.results);
            this.Controls.Add(this.VA);
            this.Controls.Add(this.VT);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label results;
    }
}

