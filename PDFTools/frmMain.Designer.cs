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
            this.grpbFiles = new System.Windows.Forms.GroupBox();
            this.txtFilenames = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.grpbFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdPDFToConvert
            // 
            this.ofdPDFToConvert.Filter = "Portable Document File (PDF)|*.pdf";
            this.ofdPDFToConvert.Multiselect = true;
            // 
            // grpbFiles
            // 
            this.grpbFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpbFiles.Controls.Add(this.txtFilenames);
            this.grpbFiles.Location = new System.Drawing.Point(12, 12);
            this.grpbFiles.Name = "grpbFiles";
            this.grpbFiles.Size = new System.Drawing.Size(400, 262);
            this.grpbFiles.TabIndex = 0;
            this.grpbFiles.TabStop = false;
            this.grpbFiles.Text = "Fichier(s)";
            // 
            // txtFilenames
            // 
            this.txtFilenames.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilenames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilenames.Enabled = false;
            this.txtFilenames.Location = new System.Drawing.Point(6, 20);
            this.txtFilenames.Name = "txtFilenames";
            this.txtFilenames.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtFilenames.Size = new System.Drawing.Size(398, 236);
            this.txtFilenames.TabIndex = 0;
            this.txtFilenames.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 280);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(119, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Parcourir ...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(137, 280);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(275, 24);
            this.btnReorder.TabIndex = 2;
            this.btnReorder.Text = "Réordonner";
            this.btnReorder.UseVisualStyleBackColor = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(424, 306);
            this.Controls.Add(this.btnReorder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.grpbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "PDFTools by Lewis";
            this.grpbFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPDFToConvert;
        private System.Windows.Forms.GroupBox grpbFiles;
        private System.Windows.Forms.RichTextBox txtFilenames;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReorder;
    }
}

