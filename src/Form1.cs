using System;
using System.Windows.Forms;

namespace Vult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();

            VultNotif.Icon = this.Icon;
            VultNotif.ContextMenu = VultNotiMenu;
            VultNotif.BalloonTipTitle = "Vult";
            VultNotif.BalloonTipText = "Vult is running in the background.";
            VultNotif.ShowBalloonTip(1000);

            SecurityInterval.Start();
        }

        public void SendNotification(string text, string title)
        {
            VultSecurityNotif.Icon = this.Icon;
            VultSecurityNotif.BalloonTipTitle = title;
            VultSecurityNotif.BalloonTipText = text;
            VultSecurityNotif.ShowBalloonTip(1000);

            VultSecurityNotif.Icon = null;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new VNMExit().Show();
        }

        private void VultNotif_Click(object sender, EventArgs e)
        {
            try
            {
                new VNMenu().Show();
            } 
            catch (Exception)
            {
                new VNMError("The Window \"VNMMenu\" failed to open. please try again!", "Window Error").Show();
            }
        }

        private void InfoItem_Click(object sender, EventArgs e)
        {
            try
            {
                new VNMInfo().Show();
            }
            catch (Exception)
            {
                new VNMError("The Window \"VNMMenu\" failed to open. please try again!", "Window Error").Show();
            }
        }

        private void SecurityInterval_Tick(object sender, EventArgs e)
        {
            VNMSecurity.ClearTempFolder();
            VNMSecurity.ScanDownloadFolder();
            VNMSecurity.CheckForCheats();
            VNMSecurity.EraseMalware();
        }
    }
}
