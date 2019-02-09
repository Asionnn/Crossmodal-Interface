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
            this.retry = new System.Windows.Forms.Button();
            this.audioRange = new System.Windows.Forms.PictureBox();
            this.tactileRange = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.audioRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tactileRange)).BeginInit();
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
            // audioRange
            // 
            this.audioRange.Image = global::Crossmodal_Interface.Properties.Resources.AudioRange1;
            this.audioRange.Location = new System.Drawing.Point(460, 500);
            this.audioRange.Name = "audioRange";
            this.audioRange.Size = new System.Drawing.Size(350, 156);
            this.audioRange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.audioRange.TabIndex = 15;
            this.audioRange.TabStop = false;
            // 
            // tactileRange
            // 
            this.tactileRange.Image = global::Crossmodal_Interface.Properties.Resources.TactileRange;
            this.tactileRange.Location = new System.Drawing.Point(460, 390);
            this.tactileRange.Name = "tactileRange";
            this.tactileRange.Size = new System.Drawing.Size(350, 156);
            this.tactileRange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tactileRange.TabIndex = 14;
            this.tactileRange.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(299, 87);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 81);
            this.startBtn.TabIndex = 16;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.audioRange);
            this.Controls.Add(this.tactileRange);
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
            ((System.ComponentModel.ISupportInitialize)(this.audioRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tactileRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button retry;
        private System.Windows.Forms.PictureBox tactileRange;
        private System.Windows.Forms.PictureBox audioRange;
        private System.Windows.Forms.Button startBtn;
    }
}

