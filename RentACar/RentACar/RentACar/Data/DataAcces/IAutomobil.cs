using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Data.Model;

namespace RentACar.Data.DataAcces
{
    public interface IAutomobil
    {
        List<Automobil> getAutomobile(string filter);
        void dodajAutomobil(Automobil a);
        void obrisiAutomobil(int idAutomobil);
        void azurirajAutomobil(Automobil a);
        Automobil getOne(int idAutomobil);
        

    }
}
