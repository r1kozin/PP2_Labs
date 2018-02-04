using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\Rus\PP2_Labs\text.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);
            string s = read.ReadToEnd();
            Console.WriteLine(s);
            file.Close();
            read.Close();
            string[] arr = s.Split(' ');
            int a;
            int b;
            int min = 1000;
            int max = int.Parse(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                a = int.Parse(arr[i]);
                b = int.Parse(arr[i]);
                
                if (a < min)
                    min = a;
                if (b > max)
                    max = b;

            }

            Console.WriteLine(max + " " + min);
            Console.ReadKey();
        }
    }
}
