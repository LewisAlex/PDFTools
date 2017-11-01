using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using org.pdfclown.files;
using org.pdfclown.tools;
using org.pdfclown.documents.contents.composition;

namespace PDFTools
{
    public class Program
    {
        public static string currentDir = Directory.GetCurrentDirectory();
        public static string workingDir = "PDFTools Working Folder";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            
            Directory.CreateDirectory(workingDir);
        }

        public static void Invert(string filename)
        {
            string fName = Path.GetFileNameWithoutExtension(filename);
            string fDir = Path.GetDirectoryName(filename);
            string fExt = Path.GetExtension(filename);

            org.pdfclown.files.File ifile = new org.pdfclown.files.File(filename);
            org.pdfclown.files.File ofile = new org.pdfclown.files.File();

            org.pdfclown.documents.Document iPdfDocument = ifile.Document;
            org.pdfclown.documents.Document oPdfDocument = ofile.Document;

            foreach (org.pdfclown.documents.Page page in iPdfDocument.Pages) {
                oPdfDocument.Pages.Add(page);
            }
            
            ofile.Save(fDir + "\\" + fName + "[reordered]" + fExt, SerializationModeEnum.Standard);

            //PdfDocument inputDocument = new PdfDocument();
            //List<int> inverted = new List<int>();

            //inputDocument.LoadFromFile(filename);

            /*
            for (int index = inputDocument.Pages.Count - 1; index >= 0; index--) {
                inverted.Add(index);
            }
            */

            //inputDocument.Pages.ReArrange(inverted.ToArray());
            //inputDocument.SaveToFile(fDir + "\\" + workingDir + "\\" + fName + fExt);
        }
    }
}