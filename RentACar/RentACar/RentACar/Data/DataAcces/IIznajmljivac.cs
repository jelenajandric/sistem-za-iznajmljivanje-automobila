using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public interface IIznajmljivac
    {
        
        List<Iznajmljivac> getIznajmljivace2();
        void dodajIznajmljivaca(Iznajmljivac i);
        Iznajmljivac getIznajmljivac(string jmb);

    }
}
