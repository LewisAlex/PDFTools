using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnReorder.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdPDFToConvert.ShowDialog() == DialogResult.OK) {
                foreach (string temp in ofdPDFToConvert.FileNames) {
                    txtFilenames.Text += temp + "\n";
                }
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            foreach (string temp in ofdPDFToConvert.FileNames) {
            }
        }
    }
}