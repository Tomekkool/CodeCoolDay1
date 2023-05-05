using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P13HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the picture URL in a given format ,https://example.com/image.jpg'");
            string url = Console.ReadLine();
            string resultPath = @"c:\Projekty\data\picture.jpg";




            WebClient wc = new WebClient();

            wc.DownloadFile(url, resultPath);

            Console.ReadKey();
        }
    }
}
