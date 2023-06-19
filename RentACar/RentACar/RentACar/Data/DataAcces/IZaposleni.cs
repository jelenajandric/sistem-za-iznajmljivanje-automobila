using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public interface IZaposleni
    {
        List<Zaposleni> getZaposlene(string filter);
        void dodajZaposlenog(Zaposleni z);
        void azurirajZaposlenog(Zaposleni z, string jmb);
        Zaposleni getOne(string jmb);
        void azurirajTemu(Zaposleni z, string jmb);
        void onemuguciNalog(string jmb, int value);
    }
}
