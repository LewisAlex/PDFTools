namespace PDFTools
{
    partial class frmMain
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
            if (disposing && (components != null)) {
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
            this.ofdPDFToConvert = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblNbConversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdPDFToConvert
            // 
            this.ofdPDFToConvert.Filter = "Portable Document File (PDF)|*.pdf";
            this.ofdPDFToConvert.Multiselect = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 220);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Parcourir ...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(137, 220);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(277, 25);
            this.btnReorder.TabIndex = 2;
            this.btnReorder.Text = "Réordonner";
            this.btnReorder.UseVisualStyleBackColor = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // pnlFiles
            // 
            this.pnlFiles.AutoScroll = true;
            this.pnlFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiles.Location = new System.Drawing.Point(2, 25);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(419, 169);
            this.pnlFiles.TabIndex = 3;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(5, 6);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(49, 13);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "Fichier(s)";
            // 
            // lblNbConversion
            // 
            this.lblNbConversion.AutoSize = true;
            this.lblNbConversion.Location = new System.Drawing.Point(8, 201);
            this.lblNbConversion.Name = "lblNbConversion";
            this.lblNbConversion.Size = new System.Drawing.Size(0, 13);
            this.lblNbConversion.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 247);
            this.Controls.Add(this.lblNbConversion);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.btnReorder);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "PDFTools by Lewis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPDFToConvert;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReorder;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblNbConversion;
    }
}

