namespace Vult
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VultNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.VultNotiMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.InfoItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // VultNotif
            // 
            this.VultNotif.Text = "Vult";
            this.VultNotif.Visible = true;
            this.VultNotif.Click += new System.EventHandler(this.VultNotif_Click);
            // 
            // VultNotiMenu
            // 
            this.VultNotiMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.InfoItem,
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "&Exit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // InfoItem
            // 
            this.InfoItem.Index = 0;
            this.InfoItem.Text = "&Info";
            this.InfoItem.Click += new System.EventHandler(this.InfoItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 40);
            this.ControlBox = false;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vult";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon VultNotif;
        private System.Windows.Forms.ContextMenu VultNotiMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem InfoItem;
    }
}

