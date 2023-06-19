using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Model
{
    public class Iznajmljivanje
    { 
        public int idIznajmljivanje { get; set; }
        public DateTime datumZaduzenja { get; set; }
        public DateTime? datumRazduzenja { get; set; }
        public int Automobil_idAutomobil { get; set; }
        public string Automobil_naziv { get; set; }
        public string Iznajmljivac_jmb { get; set; }
        public string Iznajmljivac_ime { get; set; }
        public string Iznajmljivac_prezime { get; set; }
        public string Zaposleni_jmb_zaduzuje { get; set; }
        public string Zaposleni_korisnickoIme_zaduzuje { get; set; }
        public string Zaposleni_jmb_razduzuje { get; set; }
        public string Zaposleni_KorisnickoIme_razduzuje { get; set; }

    }
}
