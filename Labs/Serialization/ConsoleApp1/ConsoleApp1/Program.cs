using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
       
            static void f1()
            {
                FileStream fs = new FileStream(@"D:\Rus\PP2_Labs\Labs\Serialization\ConsoleApp1\data.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Complex));
                Complex complex = new Complex();

                try
                {
                    xmlSerializer.Serialize(fs, complex);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    fs.Close();
                }
                Console.WriteLine("serialization completed");


            }
            static void f2()
            {
                FileStream fs = new FileStream(@"D:\Rus\PP2_Labs\Labs\Serialization\ConsoleApp1\data.xml", FileMode.Open, FileAccess.ReadWrite);
                Complex c = new Complex();

                XmlSerializer serializer = new XmlSerializer(typeof(Complex));
                try
                {
                    c = (Complex)serializer.Deserialize(fs);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    fs.Close();
                }
                Console.WriteLine(c);
            }
            static void Main(string[] args)
            {
                f1();
                f2();
                Console.ReadKey();
            }

        }
    }

