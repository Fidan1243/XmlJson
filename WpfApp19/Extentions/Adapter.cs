using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public class Adapter
    {
        private readonly IAdapter _adapter;
        public Adapter(IAdapter adapter)
        {
            _adapter = adapter;
        }
        public void Serializer(Person person)
        {
            _adapter.Serializer(person);
        }
        public Person Deserializer()
        {
            return _adapter.Deserializer();
        }
    }
}
