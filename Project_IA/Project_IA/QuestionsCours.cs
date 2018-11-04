using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Project_IA
{   // Dans le fichier XML, penser à mettre au minimum 20 questions avant d'essayer de le lire sinon erreur
    public class QuestionsCours
    {
        public string question { get;  set; }
        public string reponse1 { get;  set; }
        public string reponse2 { get;  set; }
        public string reponse3 { get;  set; }
        public string reponse4 { get;  set; }
        public string bonnereponse;
        public string explicationBonneReponse { get; set; } // Penser à ajouter les balises dans le fichier XML
        public List<QuestionsCours> questionsCours;
        Random random;
        public static List<QuestionsCours> quizzzzz { get; set; }

        public QuestionsCours(string _question, string _reponse1, string _reponse2, string _reponse3, string _reponse4, string _bonnereponse, string _explicationBonneReponse)
        {
            question = _question;
            reponse1 = _reponse1;
            reponse2 = _reponse2;
            reponse3 = _reponse3;
            reponse4 = _reponse4;
            bonnereponse = _bonnereponse;
            explicationBonneReponse = _explicationBonneReponse;
        }
        public QuestionsCours(){ }

        public List<QuestionsCours> deserializeFromXmlFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionsCours>));

            StreamReader reader = new StreamReader(filePath);
            questionsCours = (List<QuestionsCours>)serializer.Deserialize(reader);
            reader.Close();
            return questionsCours;
        }

        public void newQuiz() 
        {
            int count = questionsCours.Count;
            int questionCount = 0;
            int[] librairie = new int[20]; 

            while (questionCount < 20)
            {
                int numRandom=0;
                bool controle = false;
                while (controle == false)
                {
                    int compteur_question = 0;
                    int randomNumber = random.Next(1, questionsCours.Count+1);
                    for (int i = 0; i < 20; i++)
                    {
                        if (librairie[i] == randomNumber)
                        {
                            compteur_question++;
                        }
                    }
                    if (compteur_question==0)
                    {
                        controle = true;
                        numRandom = randomNumber;
                        librairie[questionCount] = randomNumber;
          
                    }
                }
                QuestionsCours nouvelleQuestion = questionsCours[numRandom];
                quizzzzz.Add(nouvelleQuestion);
                questionCount++;

            }
        }


    }
}
