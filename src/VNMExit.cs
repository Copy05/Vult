using System;
using System.Windows.Forms;

namespace Vult
{
    public partial class VNMExit : Form
    {
        public VNMExit()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
