using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Project_IA
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Test list = null;
            list = Test.Charger("test3.xml");

            foreach (QuestionsCours element in list)
            {
                Console.WriteLine(element.GetQuestion());
            }
            Console.ReadLine();

        }
        /*public static List<QuestionsCours> DeserializeFromXml(string filePath)
        {
           List<QuestionsCours> questions = null;

            XmlSerializer serializer = new XmlSerializer(typeof(QuestionsCours));

            StreamReader reader = new StreamReader(filePath);
            questions = (List<QuestionsCours>)serializer.Deserialize(reader);
            reader.Close();
            return questions;
        }*/
    }
}
