using System;
using System.IO;
using System.Windows.Forms;

namespace Vult
{
    public partial class VNMDetection : Form
    {
        public string m_filename;
        public VNMDetection(string file)
        {
            m_filename = file;
            InitializeComponent();
        }

        private void VNMDetection_Load(object sender, EventArgs e)
        {
            FilenameLabel.Text = m_filename;
            this.BringToFront();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            File.Delete(m_filename);
            Close();
        }

        private void KeepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
