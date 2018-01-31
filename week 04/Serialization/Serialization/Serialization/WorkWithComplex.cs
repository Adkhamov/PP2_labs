using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class WorkWithComplex
    {
        public static void ComplexWrite(Complex c1, int n)
        {
            StreamWriter sw = new StreamWriter(@"Complex" + n + ".txt");
            sw.WriteLine(c1.a);
            sw.WriteLine(c1.b);
            sw.Close();
        }

        public static void ComplexRead(int n)
        {
            StreamReader sr = new StreamReader(@"Complex" + n + ".txt");
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            Complex c = new Complex(a, b);
            sr.Close();
            Console.WriteLine(c.a + "/" + c.b);
        }

        public static void ComplexFileStreamIn(Complex c3, int n)
        {
            FileStream fs = new FileStream(@"data" + n + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            try
            {
                xs.Serialize(fs, c3);
                n++;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
            finally
            {
                fs.Close();
            }
        }

        public static void ComplexFileStreamOut(int n)
        {
            FileStream fs = new FileStream(@"data" + n + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            try
            {
                Complex b = xs.Deserialize(fs) as Complex;
                Console.WriteLine(b.a + "/" + b.b);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
           
        }

        public static void ComplexBinaryFormIn(Complex c4, int n)
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fs = new FileStream(@"data" + n + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                bf.Serialize(fs, c4);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
            finally
            {
                fs.Close();
            }
        
        }

        public static void ComplexBinaryFormOut(int n)
        {
            FileStream fs = new FileStream(@"data" + n + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                Complex b = bf.Deserialize(fs) as Complex;
                Console.WriteLine(b.a + "/" + b.b);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
            
        }
        

    }
}
