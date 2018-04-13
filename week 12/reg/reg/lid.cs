using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace reg
{
    public class lid
    {
        public string email, pass;

        public lid() { }

        public lid(string _email, string _pass)
        {
            email = _email;
            email = _pass;
        }

        public static void lidFileStreamIn( lid Lid, int n)
        {
            FileStream fs = new FileStream(@"data" + n + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(lid));
            try
            {
                xs.Serialize(fs, Lid);
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

        public static lid lidFileStreamOut(int n)
        {
            FileStream fs = new FileStream(@"data" + n + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(lid));
            try
            {
                lid b = xs.Deserialize(fs) as lid;
                return b;
            }
            catch (Exception e)
            {
                lid c = new lid();
                return c;
            }

        }

    }
}
