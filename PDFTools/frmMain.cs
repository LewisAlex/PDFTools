using System;
using System.Drawing;
using System.IO;
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
            int offset = 5, counter = 0;

            if (ofdPDFToConvert.ShowDialog() == DialogResult.OK) {
                foreach (string temp in ofdPDFToConvert.FileNames) {
                    Label lblFile = new Label();

                    pnlFiles.Controls.Add(lblFile);
                    lblFile.Location = new Point(10, offset);
                    lblFile.AutoSize = true;
                    lblFile.Name = "lblFile" + Path.GetFileNameWithoutExtension(temp);
                    lblFile.Text = temp;

                    offset += 20;
                    counter++;
                }

                if (counter == 1) {
                    lblNbConversion.Text = "1 fichier prêt pour la conversion...";
                } else {
                    lblNbConversion.Text = String.Format("{0} fichiers prêts pour la conversion...", counter);
                }

                btnReorder.Enabled = true;
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            foreach (Label temp in pnlFiles.Controls) {
                Program.Invert(temp.Text);
            }
        }
    }
}