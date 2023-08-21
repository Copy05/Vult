using System;
using System.Windows.Forms;

namespace Vult
{
    public partial class VNMError : Form
    {
        public string m_text, m_caption;
        public VNMError(string text, string caption)
        {
            m_text = text;
            m_caption = caption;
            InitializeComponent();
        }

        private void VNMError_Load(object sender, EventArgs e)
        {
            MessageText.Text = m_text;
            MessageCaption.Text = m_caption;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
