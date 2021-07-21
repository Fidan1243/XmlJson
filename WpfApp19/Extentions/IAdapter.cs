using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Models;

namespace WpfApp19.Extentions
{
    public interface IAdapter
    {
        void Serializer(Person person);
        Person Deserializer();
    }
}
