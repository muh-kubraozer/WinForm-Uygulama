using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Win32.SafeHandles;

namespace HorseRaceDomain.DataCollectors
{
    class HorseInfoCollector
    {
        private string path;
        public HorseInfoCollector(string path)
        {
            this.path = path;
        }

        public List<Horse> GetHorses()
        {
            List<Horse> horseList = new List<Horse>();
            XmlDocument document = new XmlDocument();
            document.Load(path);

            foreach (XmlNode node in document.GetElementsByTagName("horse"))
            {
                if (node.Attributes != null && node.Attributes.Count > 0)
                {
                    horseList.Add(new Horse(
                        node.Attributes[0].Value,
                        (HorseTypes)Convert.ToInt32(node.Attributes[1].Value),
                        Convert.ToDecimal(node.Attributes[2].Value),
                        (FieldTypes)Convert.ToInt32(node.Attributes[3].Value)
                    ));
                }
            }

            return horseList;
        }
    }
}
