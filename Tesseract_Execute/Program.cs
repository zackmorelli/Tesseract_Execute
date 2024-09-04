using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Tesseract;

namespace Tesseract_Execute
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            string tesstext = null;

            //Console.WriteLine("Please enter the file path for Tesseract to use:\n\n");
            //filePath = Console.ReadLine();

            int k = filePath.LastIndexOf("\\");
            string fname = filePath.Substring(k + 1);

            using (var engine = new TesseractEngine(@"C:\prog\Tesseract_Execute\tessdata", "eng", EngineMode.LstmOnly))
            {
                Pix pix = Pix.LoadFromFile(filePath);
                using (var page = engine.Process(pix))
                {
                    tesstext = page.GetText();
                }
            }

            using (StreamWriter Lwrite = File.AppendText(@"\\wvariafssp01ss\VA_DATA$\ProgramData\Vision\Tesseract_OCR_Files\Output_Text\TESSERACT_OUTPUT_" + fname + ".txt"))
            {
                Lwrite.Write(tesstext);
            }

            //Console.WriteLine("\n\nComplete.");
            //Console.ReadLine();

        }
    }
}
