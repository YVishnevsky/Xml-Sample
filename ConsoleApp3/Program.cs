using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("1000049.xml");  

            XmlNodeList xnList = xml.SelectNodes("/ZVIT/ORG/CARD/DOCUMENT/*[@TAB=0 and @LINE=0 and @NAME='FIRM_NAME']");
            foreach (XmlNode xn in xnList)
            {
                Console.WriteLine(xn.InnerText);
            }
            Console.ReadKey();
        }
    }
}
