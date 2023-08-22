namespace Vult
{
    partial class VNMDetection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNMDetection));
            this.KeepBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.MessageCaption = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeepBtn
            // 
            this.KeepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.KeepBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.KeepBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.KeepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeepBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepBtn.ForeColor = System.Drawing.Color.White;
            this.KeepBtn.Location = new System.Drawing.Point(544, 208);
            this.KeepBtn.Name = "KeepBtn";
            this.KeepBtn.Size = new System.Drawing.Size(135, 39);
            this.KeepBtn.TabIndex = 15;
            this.KeepBtn.Text = "Keep";
            this.KeepBtn.UseVisualStyleBackColor = false;
            this.KeepBtn.Click += new System.EventHandler(this.KeepBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(25, 208);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(135, 39);
            this.Deletebtn.TabIndex = 14;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // MessageCaption
            // 
            this.MessageCaption.AutoSize = true;
            this.MessageCaption.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MessageCaption.Location = new System.Drawing.Point(196, 31);
            this.MessageCaption.Name = "MessageCaption";
            this.MessageCaption.Size = new System.Drawing.Size(255, 45);
            this.MessageCaption.TabIndex = 13;
            this.MessageCaption.Text = "Are you Sure?";
            this.MessageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.White;
            this.MessageText.Location = new System.Drawing.Point(189, 87);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(277, 19);
            this.MessageText.TabIndex = 12;
            this.MessageText.Text = "We\'ve found a suspicious looking file:";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilenameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FilenameLabel.Location = new System.Drawing.Point(20, 130);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(55, 25);
            this.FilenameLabel.TabIndex = 16;
            this.FilenameLabel.Text = "FILE";
            this.FilenameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VNMDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(708, 274);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.KeepBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.MessageCaption);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(708, 274);
            this.MinimumSize = new System.Drawing.Size(708, 274);
            this.Name = "VNMDetection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNMDetection";
            this.Load += new System.EventHandler(this.VNMDetection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KeepBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label MessageCaption;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label FilenameLabel;
    }
}