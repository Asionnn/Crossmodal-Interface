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
            this.results = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.MinGain = new System.Windows.Forms.Button();
            this.MaxGain = new System.Windows.Forms.Button();
            this.retry = new System.Windows.Forms.Button();
            this.LowGain = new System.Windows.Forms.Button();
            this.HighGain = new System.Windows.Forms.Button();
            this.MinDecibel = new System.Windows.Forms.Button();
            this.LowDecibel = new System.Windows.Forms.Button();
            this.HighDecibel = new System.Windows.Forms.Button();
            this.MaxDecibel = new System.Windows.Forms.Button();
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
            // results
            // 
            this.results.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(380, 73);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 13);
            this.results.TabIndex = 12;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(299, 87);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 75);
            this.startBtn.TabIndex = 16;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MinGain
            // 
            this.MinGain.Location = new System.Drawing.Point(117, 308);
            this.MinGain.Name = "MinGain";
            this.MinGain.Size = new System.Drawing.Size(60, 60);
            this.MinGain.TabIndex = 17;
            this.MinGain.Text = "Min Gain";
            this.MinGain.UseVisualStyleBackColor = true;
            this.MinGain.Click += new System.EventHandler(this.MinGain_Click);
            // 
            // MaxGain
            // 
            this.MaxGain.Location = new System.Drawing.Point(314, 308);
            this.MaxGain.Name = "MaxGain";
            this.MaxGain.Size = new System.Drawing.Size(60, 60);
            this.MaxGain.TabIndex = 18;
            this.MaxGain.Text = "Max Gain";
            this.MaxGain.UseVisualStyleBackColor = true;
            this.MaxGain.Click += new System.EventHandler(this.MaxGain_Click);
            // 
            // retry
            // 
            this.retry.Location = new System.Drawing.Point(600, 364);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(62, 46);
            this.retry.TabIndex = 13;
            this.retry.Text = "Retry";
            this.retry.UseVisualStyleBackColor = true;
            this.retry.Visible = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // LowGain
            // 
            this.LowGain.Location = new System.Drawing.Point(183, 308);
            this.LowGain.Name = "LowGain";
            this.LowGain.Size = new System.Drawing.Size(60, 60);
            this.LowGain.TabIndex = 19;
            this.LowGain.Text = "Low Gain";
            this.LowGain.UseVisualStyleBackColor = true;
            this.LowGain.Click += new System.EventHandler(this.LowGain_Click);
            // 
            // HighGain
            // 
            this.HighGain.Location = new System.Drawing.Point(249, 308);
            this.HighGain.Name = "HighGain";
            this.HighGain.Size = new System.Drawing.Size(60, 60);
            this.HighGain.TabIndex = 20;
            this.HighGain.Text = "High Gain";
            this.HighGain.UseVisualStyleBackColor = true;
            this.HighGain.Click += new System.EventHandler(this.HighGain_Click);
            // 
            // MinDecibel
            // 
            this.MinDecibel.Location = new System.Drawing.Point(117, 410);
            this.MinDecibel.Name = "MinDecibel";
            this.MinDecibel.Size = new System.Drawing.Size(60, 60);
            this.MinDecibel.TabIndex = 21;
            this.MinDecibel.Text = "Min Decibel";
            this.MinDecibel.UseVisualStyleBackColor = true;
            this.MinDecibel.Click += new System.EventHandler(this.MinDecibel_Click);
            // 
            // LowDecibel
            // 
            this.LowDecibel.Location = new System.Drawing.Point(183, 410);
            this.LowDecibel.Name = "LowDecibel";
            this.LowDecibel.Size = new System.Drawing.Size(60, 60);
            this.LowDecibel.TabIndex = 22;
            this.LowDecibel.Text = "Low Decibel";
            this.LowDecibel.UseVisualStyleBackColor = true;
            this.LowDecibel.Click += new System.EventHandler(this.LowDecibel_Click);
            // 
            // HighDecibel
            // 
            this.HighDecibel.Location = new System.Drawing.Point(249, 410);
            this.HighDecibel.Name = "HighDecibel";
            this.HighDecibel.Size = new System.Drawing.Size(60, 60);
            this.HighDecibel.TabIndex = 23;
            this.HighDecibel.Text = "High Decibel";
            this.HighDecibel.UseVisualStyleBackColor = true;
            this.HighDecibel.Click += new System.EventHandler(this.HighDecibel_Click);
            // 
            // MaxDecibel
            // 
            this.MaxDecibel.Location = new System.Drawing.Point(320, 410);
            this.MaxDecibel.Name = "MaxDecibel";
            this.MaxDecibel.Size = new System.Drawing.Size(60, 60);
            this.MaxDecibel.TabIndex = 24;
            this.MaxDecibel.Text = "Max Decibel";
            this.MaxDecibel.UseVisualStyleBackColor = true;
            this.MaxDecibel.Click += new System.EventHandler(this.MaxDecibel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.MaxDecibel);
            this.Controls.Add(this.HighDecibel);
            this.Controls.Add(this.LowDecibel);
            this.Controls.Add(this.MinDecibel);
            this.Controls.Add(this.HighGain);
            this.Controls.Add(this.LowGain);
            this.Controls.Add(this.MaxGain);
            this.Controls.Add(this.MinGain);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.results);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button MinGain;
        private System.Windows.Forms.Button MaxGain;
        private System.Windows.Forms.Button retry;
        private System.Windows.Forms.Button LowGain;
        private System.Windows.Forms.Button HighGain;
        private System.Windows.Forms.Button MinDecibel;
        private System.Windows.Forms.Button LowDecibel;
        private System.Windows.Forms.Button HighDecibel;
        private System.Windows.Forms.Button MaxDecibel;
    }
}

