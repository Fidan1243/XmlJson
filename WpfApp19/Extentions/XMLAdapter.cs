using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public class XMLAdapter : IAdapter
    {
        private readonly XML _xml;
        public XMLAdapter(XML xml)
        {
            _xml = xml;
        }

        public Person Deserializer()
        {
            return _xml.XMLDeserializer();
        }

        public void Serializer(Person person)
        {
            _xml.XMLSerializer(person);
        }
    }
}
