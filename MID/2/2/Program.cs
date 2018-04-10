using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamReader fs = new StreamReader(@"D:\Rus\PP2_Labs\MID\2"+"text"+".txt");
            //FileStream fs = new FileStream(@"D:\Rus\PP2_Labs\MID\2" + "text" + ".txt",FileMode.OpenOrCreate);
            int min = 100000;
            int min1=100000
                ;
            string p = File.ReadAllText(@"D:\Rus\PP2_Labs\MID\2\text.txt");
            string[] s = p.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                int t = int.Parse(s[i]);
                if (t < min)
                {
                    min = t;
                }
            }
                for (int j = 0; j < s.Length; j++)
                {
                    
                    if (int.Parse(s[j]) == min)
                    { continue; }
                    if (int.Parse(s[j]) < min1)
                    {
                        min1 = int.Parse(s[j]);
                    }

                }
               
                File.WriteAllText(@"D:\Rus\PP2_Labs\MID\2\text1.txt","min"+"="+min1);
                Console.ReadKey();



            
        }
    }
}

