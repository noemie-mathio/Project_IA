using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Project_IA
{  
    public class QuestionsCours
    {
        public string question { get;  set; }
        public string reponse1 { get;  set; }
        public string reponse2 { get;  set; }
        public string reponse3 { get;  set; }
        public string reponse4 { get;  set; }
        public string bonnereponse;
        public List<QuestionsCours> questionsCours;
        Random random;



        public QuestionsCours(string _question, string _reponse1, string _reponse2, string _reponse3, string _reponse4, string _bonnereponse)
        {
            question = _question;
            reponse1 = _reponse1;
            reponse2 = _reponse2;
            reponse3 = _reponse3;
            reponse4 = _reponse4;
            bonnereponse = _bonnereponse;
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

        public List<QuestionsCours> newQuiz() //à revoir
        {
            int count = questionsCours.Count;
            int questionCount = 0;
            List<QuestionsCours> questionsQuiz = new List<QuestionsCours>();
            int[] librairie = new int[20]; 

            while (questionCount < 20)
            {
                int numRandom=0;
                bool controle = false;
                while (controle == false)
                {
                    int randomNumber = random.Next(1, questionsCours.Count+1);
                    for (int i = 0; i < 20; i++)
                    {
                        if (librairie[i] != randomNumber)
                        {
                            controle = true;
                            numRandom = randomNumber;
                            librairie[i] = randomNumber;
                        }
                    }
                }
                QuestionsCours randSong = questionsCours[numRandom];
                if (!questionsQuiz.Contains(randSong))
                {
                    questionsQuiz.Add(randSong);
                    questionCount++;
                }
            }
            return questionsQuiz;
        }


    }
}
