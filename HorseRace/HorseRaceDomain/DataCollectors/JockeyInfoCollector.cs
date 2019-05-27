using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HorseRaceDomain.DataCollectors
{
    class JockeyInfoCollector
    {
        private string path;
        public JockeyInfoCollector(string path)
        {
            this.path = path;
        }

        public List<Jockey> GetJockeys()
        {
            List<Jockey> jockeyList = new List<Jockey>();
            XmlDocument document = new XmlDocument();
            document.Load(path);

            foreach (XmlNode node in document.GetElementsByTagName("jockey"))
            {
                jockeyList.Add(
                    new Jockey(
                        node.ChildNodes[0].InnerText,
                        Convert.ToDecimal(node.ChildNodes[1].InnerText),
                        (HorseTypes)Convert.ToInt32(node.ChildNodes[2].InnerText)
                    ));
            }
            return jockeyList;
        }
    }
}
