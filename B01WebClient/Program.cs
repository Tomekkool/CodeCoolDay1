using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B01WebClient
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient myWebClient = new WebClient();

            string url = "https://www.google.com/search?q=weather+krak%C3%B3w";    
            string data = myWebClient.DownloadString(url);

            Console.WriteLine(data);

            //string resultPath = "c:\\Projekty\\data\\page.html";

            string resultPath = @"c:\Projekty\data\page.html";

            File.WriteAllText(resultPath, data);

            Console.ReadKey();
            



        }
    }
}
