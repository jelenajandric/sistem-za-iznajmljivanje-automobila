using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public interface IOsoba
    {
        //List<Osoba> getOsobe();
        void addOsoba(Osoba o);
        void azurirajOsobu(Osoba o);
        void izbrisiOsobu(string jmb);

        Osoba getOne(string jmb);
    }
}
