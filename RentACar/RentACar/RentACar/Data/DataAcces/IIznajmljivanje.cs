using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public interface IIznajmljivanje
    {
        List<Iznajmljivanje> getIznajmljivanja(string filter);
        void dodajIznajmljivanje(Iznajmljivanje i);
        void azurirajIznajmljivanje(DateTime vrijemeRazd, Zaposleni jmbRazduzivaca, int idAuto);
        DateTime GetVrijemeIznajmljivanja(int idAutomobil);
        void izbrisiIznajmljivanja(int idAuto);
    }
}
