using MySql.Data.MySqlClient;
using RentACar.Data.DataAcces.Exceptions;
using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces.MySql
{
    public class MySqlIznajmljivac : IIznajmljivac
    {
        private static readonly string INSERT = "INSERT INTO `iznajmljivac`(jmb, adresa) VALUES (@jmb, @adresa)";
        private static readonly string GETONE = "SELECT jmb, ime, prezime, brojTelefona, email, adresa FROM `osoba` NATURAL JOIN `iznajmljivac` WHERE jmb=@jmb";
        private static readonly string SELECT = "SELECT ime, prezime, jmb FROM `osoba` NATURAL JOIN `iznajmljivac`";


        public void dodajIznajmljivaca(Iznajmljivac i)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@jmb", i.jmb);
                cmd.Parameters.AddWithValue("@adresa", i.adresa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Iznajmljivac getIznajmljivac(string jmb)
        {
            Iznajmljivac result = new Iznajmljivac();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = GETONE;
                cmd.Parameters.AddWithValue("@jmb", jmb);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Iznajmljivac()
                    {
                        jmb = reader.GetString(0),
                        ime = reader.GetString(1),
                        prezime = reader.GetString(2),
                        brojTelefona = reader.GetString(3),
                        email = reader.GetString(4),
                        adresa = reader.GetString(5)

                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<Iznajmljivac> getIznajmljivace2()
        {
            List<Iznajmljivac> result = new List<Iznajmljivac>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Iznajmljivac()
                    {
                        ime = reader.GetString(0),
                        prezime = reader.GetString(1),
                        jmb = reader.GetString(2)

                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
