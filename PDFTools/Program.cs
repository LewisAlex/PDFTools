using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;

namespace PDFTools
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string workingDir = Directory.GetCurrentDirectory() + "\\PDFTools Working Folder";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());


            Directory.CreateDirectory(workingDir);
        }

        public void Invert(string filename)
        {
            PdfDocument inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);
            PdfDocument outputDocument = new PdfDocument();

            for(int index = inputDocument.PageCount; index < 1; index--) {
                outputDocument.AddPage(inputDocument.Pages[index]);
            }

            outputDocument.Save(filename);

        }
    }
}