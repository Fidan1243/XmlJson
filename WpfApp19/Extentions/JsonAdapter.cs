using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public class JsonAdapter : IAdapter
    {
        private readonly Json _js;

        public JsonAdapter(Json json)
        {
            _js = json;
        }

        public Person Deserializer()
        {
            return _js.JsonDeserializer();
        }

        public void Serializer(Person person)
        {
            _js.JsonSerializer(person);
        }
    }
}
