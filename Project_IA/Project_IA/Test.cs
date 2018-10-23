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

    public class Test : List<QuestionsCours>
    {
        public static Test Charger(string chemin)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Test));
            StreamReader lecteur = new StreamReader(chemin);
            Test p = (Test)deserializer.Deserialize(lecteur);
            lecteur.Close();

            return p;
        }
    }
}
