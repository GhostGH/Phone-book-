using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонна_книжка__WinForms_EF_
{
    public class PhoneContact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Number { get; set; }
        public PhoneContact()
        {

        }

        public PhoneContact( string? name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
