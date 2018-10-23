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
    [Serializable()]

    public class QuestionsCours
    {
        private string question;
        private string reponse1;
        private string reponse2;
        private string reponse3;
        private string reponse4;
        private string bonnereponse;
        
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
