using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkTime = 0;
            using (StreamReader sr = new StreamReader("INPUT.TXT"))
            {
                string time = sr.ReadLine();
                int hours = (time[0] - 48) * 10 + (time[1] - 48);
                int minutes = (time[3] - 48) * 10 + (time[4] - 48);

                if (hours < 10)
                {
                    checkTime = 1200 - hours * 60 - minutes;
                }
                else if (hours >= 10 && hours < 17)
                {
                    checkTime = (1440 - hours * 60 - minutes);
                }
                else if (hours == 17)
                {
                    checkTime = (1440 - hours * 60 - minutes + 1320 - hours * 60);
                }
                else if (hours == 18)
                {
                    checkTime = (1440 - hours * 60 - minutes + 1380 - hours * 60);
                }
                else if (hours < 20)
                {
                    checkTime = (1440 - hours * 60 - minutes + 1440 - hours * 60);
                }
                else
                {
                    checkTime = (1440 - hours * 60 - minutes) + 600;
                }
            }

            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.Write(checkTime);
            }
        }
    }
}