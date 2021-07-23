using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public class Json
    {
        public void JsonSerializer(Person person)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Person.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, person);
                }
            }
        }
        public Person JsonDeserializer()
        {
            Person person = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("Person.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    person = serializer.Deserialize<Person>(jr);
                }
            }

            return person;
        }
    }
}
