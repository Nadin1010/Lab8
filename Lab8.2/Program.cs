using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._2
{
    class program
    {
        static void Main(string[] args)

        {//програмно создаем текстовый файл. записываем в него 10 случайных чисел//
            string path = "Task_8-2.txt";
            Random random = new Random();
            int S = 0;
            using (StreamWriter sw = new StreamWriter(path))
            { for (int i = 0; i < 10; i++)
                {
                    int x = random.Next(0, 10);
                        sw.WriteLine(x);
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        int x = Convert.ToInt32(sr.ReadLine());
                        S += x;
                    }
                    Console.WriteLine(S);
                    Console.ReadKey();
                }
            }

        }
    }
}




