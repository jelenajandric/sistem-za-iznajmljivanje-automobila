using MySql.Data.MySqlClient;
using RentACar.Data.DataAcces.Exceptions;
using RentACar.Data.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.DataAcces.MySql
{
    public class MySqlZaposleni : IZaposleni
    {
        private static readonly string SELECT = "SELECT jmb, ime, prezime ,brojTelefona, email, korisnickoIme, lozinka, tema, onemogucen FROM `osoba` NATURAL JOIN `zaposleni` WHERE ime LIKE @str OR prezime LIKE @str ORDER BY prezime";
        private static readonly string INSERT = "INSERT INTO `zaposleni`(jmb, korisnickoIme, lozinka, tema) VALUES (@jmb, @korisnickoIme, @lozinka, @tema)";
        private static readonly string UPDATE = "UPDATE `zaposleni` SET korisnickoIme=@korisnickoIme, lozinka=@lozinka WHERE jmb=@jmb";
        private static readonly string GETONE = "SELECT korisnickoIme, lozinka,tema,  jmb, onemogucen FROM `zaposleni` WHERE jmb=@jmb";
        private static readonly string UPDATETEMA = "UPDATE `zaposleni` SET tema=@tema WHERE jmb=@jmb";
        private static readonly string UPDATEONEMOGUCEN = "UPDATE `zaposleni` SET onemogucen=@onemogucen WHERE jmb=@jmb";


        public List<Zaposleni> getZaposlene(string filter)
        {
            List<Zaposleni> result = new List<Zaposleni>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Zaposleni()
                    {
                        jmb = reader.GetString(0),
                        ime = reader.GetString(1),
                        prezime = reader.GetString(2),
                        brojTelefona = reader.GetString(3),
                        email = reader.GetString(4),
                        korisnickoIme = reader.GetString(5),
                        lozinka = reader.GetString(6),
                        tema = reader.GetString(7),
                        onemogucen = reader.GetInt32(8)
                    });
                    Debug.WriteLine("EEE");
                }

                for(int i=0; i< result.Count(); i++)
                {
                    Debug.WriteLine(result[i].korisnickoIme);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposleni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void dodajZaposlenog(Zaposleni z)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@jmb", z.jmb);
                cmd.Parameters.AddWithValue("@korisnickoIme", z.korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", z.lozinka);
                cmd.Parameters.AddWithValue("@tema", "Standardna");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposleni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void azurirajZaposlenog(Zaposleni z, string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@korisnickoIme", z.korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", z.lozinka);
                cmd.Parameters.AddWithValue("@jmb", jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposleni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Zaposleni getOne(string jmb)
        {
            Zaposleni result = new Zaposleni();
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
                reader.Read();
                
                result = new Zaposleni()
                {
                    korisnickoIme = reader.GetString(0),
                    lozinka = reader.GetString(1),
                    tema = reader.GetString(2),
                    jmb = reader.GetString(3),
                    onemogucen = reader.GetInt32(4)

                };

            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZapolseni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void azurirajTemu(Zaposleni z, string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATETEMA;
                cmd.Parameters.AddWithValue("@tema", z.tema);
                cmd.Parameters.AddWithValue("@jmb", z.jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposleni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void onemuguciNalog(string jmb, int value)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATEONEMOGUCEN;
                cmd.Parameters.AddWithValue("@onemogucen", value);
                cmd.Parameters.AddWithValue("@jmb", jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposleni", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
