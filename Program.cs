using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Tesseract;

namespace PDFnamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.ReadKey();
            Bitmap image = new Bitmap("C:\\Users\\SEQVQQ\\source\\repos\\PDFnamer\\test.png");
            //Bitmap image = new Bitmap(@"test.png");
            Console.WriteLine(image.Size.Width);
            Console.ReadKey();
            TesseractEngine engine = new TesseractEngine(@"./tessdata", "swe", EngineMode.Default);
            Page results = engine.Process(image);

            Console.WriteLine(results.ToString());
        }
    }
}
