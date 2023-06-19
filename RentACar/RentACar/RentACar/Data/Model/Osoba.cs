using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Model
{
    public class Osoba
    {
        public string jmb { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string brojTelefona { get; set; }
        public string email { get; set; }
        public override string ToString()
        {
            string str = ime + " " + prezime + " JMB:" + jmb;
            return str;
        }

    }
}
