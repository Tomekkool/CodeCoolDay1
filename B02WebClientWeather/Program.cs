using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B02WebClientWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchChar = "°";
            string endChar = ">";

            while (true)//infinite loop
            {
            Console.WriteLine("Please type the name of a City you would like to know the temerature");
            string city = Console.ReadLine();

            string url = $"https://www.google.com/search?q=weather+{city}";


            WebClient wc = new WebClient();

            string data = wc.DownloadString(url);

           
                try
                {
                    int index = data.IndexOf(searchChar);
                    int currentPosition = index;
                    int iterationCount = 0;

                    while (data.Substring(currentPosition, 1) != endChar)
                    {
                        iterationCount++;
                        currentPosition--;
                    }

                    string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to retreive a temperature");
                    continue;
                }
           
        }
            Console.ReadKey();
        }
    }
}
