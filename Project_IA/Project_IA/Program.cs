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
            List<QuestionsCours> list = new List<QuestionsCours>();
            list= DeserializeFromXml("test.xml");

        }
        public static List<QuestionsCours> DeserializeFromXml(string filePath)
        {
            //lSerializer deserializer = new XmlSerializer(typeof(List<QuestionsCours>));
            StreamReader reader = new StreamReader(filePath);
            List<QuestionsCours> list;
            XmlSerializer xs = new XmlSerializer(typeof(QuestionsCours));
            list = XmlSerializer.;
                (typeof(List<QuestionsCours>)).Deserialize(reader);
            reader.Close();

            return list;
        }
    }
}
