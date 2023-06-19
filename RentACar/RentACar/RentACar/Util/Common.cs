using RentACar.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Util
{
    class Common
    {
        private static DataFactory dataFactory;
        public static DataFactory DataFactory
        {
            get
            {
                if (dataFactory == null)
                {
                    dataFactory = DataFactory.GetMySqlDataFactory();
                }
                return dataFactory;
            }
        }

        private static string dateFormat;
        public static string DateFormat
        {
            get
            {
                if (dateFormat == null)
                {
                    dateFormat = ConfigurationManager.AppSettings["DateFormat"];
                    if (dateFormat == null)
                    {
                        dateFormat = "dd.MM.yyyy.";
                    }
                }
                return dateFormat;
            }
        }
    }
}
