using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces
{
    public interface IAdministrator
    {
        List<Administrator> getAdministratore();
        void azurirajAdministratora(Administrator a, string jmb);
        Administrator getOne(string jmb);
        void azurirajTemu(Administrator a, string jmb);
    }
}
