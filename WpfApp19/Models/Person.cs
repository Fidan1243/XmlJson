using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp19.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nEMail: {Email}";
        }
    }
}
