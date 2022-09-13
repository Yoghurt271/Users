using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Cotegory
    {
        public string Namecot;
        public Tovar[] Tovars;
        public Cotegory(string namecot, Tovar[] tovars)
        {
            Namecot = namecot;
            Tovars = tovars;
        }
    }
}
