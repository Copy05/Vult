using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vult
{
    public partial class VNMenu : Form
    {
        public VNMenu()
        {
            InitializeComponent();
        }

        private void VNMenu_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VNMenu_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
