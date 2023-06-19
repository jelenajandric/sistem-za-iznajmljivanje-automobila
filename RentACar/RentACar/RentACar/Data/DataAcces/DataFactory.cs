using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public abstract class DataFactory
    {

        public abstract IOsoba Osobe { get; }
        public abstract IIznajmljivac Iznajmljivaci { get; }
        public abstract IZaposleni Zaposleni { get; }
        public abstract IAdministrator Administratori { get; }
        public abstract IIznajmljivanje Iznajmljivanja { get; }
        public abstract IAutomobil Automobili { get; }
        public static DataFactory GetMySqlDataFactory()
        {
            return new MySql.MySqlDataFactory();
        }
    }
}
