using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public class XML
    {
        public void XMLSerializer(Person person)
        {
            var xml = new XmlSerializer(typeof(Person));
            using (var fs = new FileStream("Person.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, person);
            }
        }
        public Person XMLDeserializer()
        {
            Person person = null;
            var xml = new XmlSerializer(typeof(Person));
            using (var fs = new FileStream("Person.xml", FileMode.OpenOrCreate))
            {
                person = xml.Deserialize(fs) as Person;
            }
            return person;
        }
    }
}
