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
    public class Test
    {
        [XmlElement("Test")]
        public List<QuestionsCours> test = new List<QuestionsCours>();
    }
    public class QuestionsCours
    {
        public string question { get;  set; }
        public string reponse1 { get;  set; }
        public string reponse2 { get;  set; }
        public string reponse3 { get;  set; }
        public string reponse4 { get;  set; }
        public string bonnereponse;
        
        public QuestionsCours(string _question, string _reponse1, string _reponse2, string _reponse3, string _reponse4, string _bonnereponse)
        {
            question = _question;
            reponse1 = _reponse1;
            reponse2 = _reponse2;
            reponse3 = _reponse3;
            reponse4 = _reponse4;
            bonnereponse = _bonnereponse;
        }
        public QuestionsCours()
        { }

        public string GetQuestion()
        { return question; }

     
    }
}
