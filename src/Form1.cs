using System;
using System.IO;
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

        private void ClearTempFolder()
        {
            var un = Environment.UserName;
            var dir = new DirectoryInfo(@"C:\Users\" + un + @"\AppData\Local\Temp");

            foreach (var file in Directory.GetFiles(dir.ToString()))
            {
                try
                {
                    File.Delete(file);
                } 
                catch (Exception e)
                {
                    // Nothing
                }
            }

            foreach (var folder in Directory.GetDirectories(dir.ToString()))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception e)
                {
                    // Nothing
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            VultNotif.Icon = this.Icon;
            VultNotif.ContextMenu = VultNotiMenu;
            VultNotif.BalloonTipTitle = "Vult";
            VultNotif.BalloonTipText = "Vult is running in the background.";
            VultNotif.ShowBalloonTip(1000);
            ClearTempFolder();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
