using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonGB4
{
   
       static class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] array = new int[size];
            Sum(array);
            SaveToFile("File.txt",size,array);
            





            Console.ReadLine();
        }

        static void Sum(int[] array)
        {

            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10000, 10000);
                int j = i - 1;

                if (i > 0)
                {
                    if ((array[i] + array[j]) % 3 == 0)
                    {
                        sum++;

                    }
                }



            }
            Console.WriteLine($"{sum}");
        }

        static void SaveToFile(string path, int size, int[] array)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < size; i++)
            {
                sw.WriteLine(array[i].ToString());
            }
            sw.Close();
        }

       
           
        }
    }





