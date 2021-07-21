using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    class Application
    {
        private readonly Adapter _adapter;
        public Application(Adapter adapter)
        {
            _adapter = adapter;
        }
        public void StartSerialize(Person person)
        {
            _adapter.Serializer(person);
        }
    }
}
