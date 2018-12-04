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
            this.VA = new System.Windows.Forms.Button();
            this.VT = new System.Windows.Forms.Button();
            this.AV = new System.Windows.Forms.Button();
            this.AT = new System.Windows.Forms.Button();
            this.TA = new System.Windows.Forms.Button();
            this.TV = new System.Windows.Forms.Button();
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
            // VA
            // 
            this.VA.Location = new System.Drawing.Point(160, 171);
            this.VA.Name = "VA";
            this.VA.Size = new System.Drawing.Size(80, 80);
            this.VA.TabIndex = 2;
            this.VA.Text = "V-A";
            this.VA.UseVisualStyleBackColor = true;
            this.VA.Click += new System.EventHandler(this.VA_Click);
            // 
            // VT
            // 
            this.VT.Location = new System.Drawing.Point(338, 171);
            this.VT.Name = "VT";
            this.VT.Size = new System.Drawing.Size(80, 80);
            this.VT.TabIndex = 3;
            this.VT.Text = "V-T";
            this.VT.UseVisualStyleBackColor = true;
            this.VT.Click += new System.EventHandler(this.VT_Click);
            // 
            // AV
            // 
            this.AV.Location = new System.Drawing.Point(508, 171);
            this.AV.Name = "AV";
            this.AV.Size = new System.Drawing.Size(80, 80);
            this.AV.TabIndex = 4;
            this.AV.Text = "A-V";
            this.AV.UseVisualStyleBackColor = true;
            this.AV.Click += new System.EventHandler(this.AV_Click);
            // 
            // AT
            // 
            this.AT.Location = new System.Drawing.Point(160, 321);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(80, 80);
            this.AT.TabIndex = 5;
            this.AT.Text = "A-T";
            this.AT.UseVisualStyleBackColor = true;
            this.AT.Click += new System.EventHandler(this.AT_Click);
            // 
            // TA
            // 
            this.TA.Location = new System.Drawing.Point(338, 321);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(80, 80);
            this.TA.TabIndex = 6;
            this.TA.Text = "T-A";
            this.TA.UseVisualStyleBackColor = true;
            this.TA.Click += new System.EventHandler(this.TA_Click);
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(508, 321);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(80, 80);
            this.TV.TabIndex = 7;
            this.TV.Text = "T-V";
            this.TV.UseVisualStyleBackColor = true;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.AV);
            this.Controls.Add(this.VT);
            this.Controls.Add(this.VA);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Crossmodal Matching";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VA;
        private System.Windows.Forms.Button VT;
        private System.Windows.Forms.Button AV;
        private System.Windows.Forms.Button AT;
        private System.Windows.Forms.Button TA;
        private System.Windows.Forms.Button TV;
    }
}

