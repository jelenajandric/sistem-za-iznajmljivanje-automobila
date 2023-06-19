using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces.MySql
{
    public class MySqlDataFactory : DataFactory
    {
        private MySqlOsoba mySqlOsoba;
        private MySqlAdministrator mySqlAdministrator;
        private MySqlZaposleni mySqlZaposleni;
        private MySqlIznajmljivac mySqlIznajmljivac;
        private MySqlIznajmljivanje mySqlIznajmljivanje;
        private MySqlAutomobil mySqlAutomobil;

        public override IOsoba Osobe
        {
            get
            {
                if (mySqlOsoba == null)
                {
                    mySqlOsoba = new MySqlOsoba();
                }
                return mySqlOsoba;
            }
        }

        public override IAdministrator Administratori
        {
            get
            {
                if (mySqlAdministrator == null)
                {
                    mySqlAdministrator = new MySqlAdministrator();
                }
                return mySqlAdministrator;
            }
        }

        public override IIznajmljivac Iznajmljivaci
        {
            get
            {
                if (mySqlIznajmljivac == null)
                {
                    mySqlIznajmljivac = new MySqlIznajmljivac();
                }
                return mySqlIznajmljivac;
            }
        }

        public override IZaposleni Zaposleni
        {
            get
            {
                if (mySqlZaposleni == null)
                {
                    mySqlZaposleni = new MySqlZaposleni();
                }
                return mySqlZaposleni;
            }
        }



        public override IIznajmljivanje Iznajmljivanja
        {
            get
            {
                if (mySqlIznajmljivanje == null)
                {
                    mySqlIznajmljivanje = new MySqlIznajmljivanje();
                }
                return mySqlIznajmljivanje;
            }
        }

        public override IAutomobil Automobili
        {
            get
            {
                if (mySqlAutomobil == null)
                {
                    mySqlAutomobil = new MySqlAutomobil();
                }
                return mySqlAutomobil;
            }
        }
    }
}
