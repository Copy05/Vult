namespace Vult
{
    partial class VNMError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNMError));
            this.Closebtn = new System.Windows.Forms.Button();
            this.MessageCaption = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(265, 178);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(135, 39);
            this.Closebtn.TabIndex = 7;
            this.Closebtn.Text = "Ok";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // MessageCaption
            // 
            this.MessageCaption.AutoSize = true;
            this.MessageCaption.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MessageCaption.Location = new System.Drawing.Point(29, 20);
            this.MessageCaption.Name = "MessageCaption";
            this.MessageCaption.Size = new System.Drawing.Size(110, 45);
            this.MessageCaption.TabIndex = 6;
            this.MessageCaption.Text = "Error";
            this.MessageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.White;
            this.MessageText.Location = new System.Drawing.Point(37, 80);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(38, 19);
            this.MessageText.TabIndex = 5;
            this.MessageText.Text = "Text";
            // 
            // VNMError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(666, 237);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.MessageCaption);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(666, 237);
            this.MinimumSize = new System.Drawing.Size(666, 237);
            this.Name = "VNMError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNMError";
            this.Load += new System.EventHandler(this.VNMError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label MessageCaption;
        private System.Windows.Forms.Label MessageText;
    }
}