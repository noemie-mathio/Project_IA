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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
           /* List<QuestionsCours> questions = new List<QuestionsCours>();
            questions = DeserializeFromXml("test_question.xml");
            int numero = 0;
            foreach (QuestionsCours element in questions)
            {
                numero++;
                Console.WriteLine(element.reponse1);
            }
            Console.WriteLine();
            Console.Read(); */


        }
        // Serialisation fonctionnelle, à modifier en tant voulue dans le programme
        public static void Serialisation(List<QuestionsCours> questions)
        {
            questions = new List<QuestionsCours>();

            QuestionsCours question_1 = new QuestionsCours("Une liaison rotule à :", "4 degrés de liberté", "3 degrés de liberté", "2 degrés de liberté", "Ca dépends", "3 degrés de liberté","Blabla");
            QuestionsCours question_2 = new QuestionsCours("Quel est la différence entre un servo-contrôleur et un micro-contrôleur?", "Purement sémantique", "Le servo-contrôleur n’est pas programmable", "Le servo-contrôleur ne fonctionne pas en autonomie", "Le micro-contrôleur ne possede pas de mémoire interne", "Le servo-contrôleur ne fonctionne pas en autonomie","Blabla");

            questions.Add(question_1);
            questions.Add(question_2);

            XmlSerializer xs = new XmlSerializer(typeof(List<QuestionsCours>));
            using (StreamWriter wr = new StreamWriter("test_question.xml"))
            {
                xs.Serialize(wr, questions);
            }


          
        }
        public static List<QuestionsCours> DeserializeFromXml(string filePath)
        {
           List<QuestionsCours> questions = null;

            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionsCours>));

            StreamReader reader = new StreamReader(filePath);
            questions = (List<QuestionsCours>)serializer.Deserialize(reader);
            reader.Close();
            return questions;
        }
    }
}
