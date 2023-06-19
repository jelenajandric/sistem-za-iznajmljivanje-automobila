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
    class MySqlIznajmljivanje : IIznajmljivanje
    {
        private static readonly string SELECT = "SELECT idIznajmljivanje, Automobil_IdAutomobil1, Automobil.naziv, osoba.ime,osoba.prezime, Iznajmljivac_jmb, z1.korisnickoIme,  Zaposleni_jmb, z2.korisnickoIme,  Zaposleni_jmb1, datumZaduzenja, datumRazduzenja FROM `Iznajmljivanje` JOIN Automobil on Automobil.idAutomobil = Automobil_idAutomobil1 JOIN osoba ON osoba.jmb = Iznajmljivac_jmb JOIN zaposleni z1 ON z1.jmb = Zaposleni_jmb JOIN zaposleni z2 ON z2.jmb = Zaposleni_jmb1 WHERE Automobil.naziv LIKE @str OR osoba.ime LIKE @str OR osoba.prezime LIKE @str OR z1.korisnickoIme LIKE @str OR z2.korisnickoIme LIKE @str";
        private static readonly string INSERT = "INSERT INTO `iznajmljivanje` (datumZaduzenja, datumRazduzenja, Zaposleni_jmb, Zaposleni_jmb1, Automobil_idAutomobil1, Iznajmljivac_jmb) VALUES (@datumZaduzenja, @datumRazduzenja, @Zaposleni_jmb, @Zaposleni_jmb1, @Automobil_idAutomobil1, @Iznajmljivac_jmb)";
        private static readonly string UPDATE = "UPDATE `iznajmljivanje` SET datumRazduzenja = @vrijemeRazduzenja, Zaposleni_jmb1 = @zaposleni_jmb1 WHERE Automobil_idAutomobil1 = @idAutomobil AND datumRazduzenja = @vrijemeRaz";
        private static readonly string GETONE = "SELECT datumZaduzenja FROM Iznajmljivanje WHERE Automobil_idAutomobil1 = @idAutomobil AND datumRazduzenja = @vrijemeRaz";        private static readonly string DELETE = "DELETE from Iznajmljivanje WHERE Automobil_idAutomobil1 = @idAuto";

        public void azurirajIznajmljivanje(DateTime vrijemeRazd, Zaposleni z, int idAuto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@vrijemeRazduzenja", vrijemeRazd);
                cmd.Parameters.AddWithValue("@zaposleni_jmb1", z.jmb);
                cmd.Parameters.AddWithValue("@idAutomobil", idAuto);
                cmd.Parameters.AddWithValue("@vrijemeRaz", DateTime.MinValue);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void dodajIznajmljivanje(Iznajmljivanje i)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@datumZaduzenja", i.datumZaduzenja);
                cmd.Parameters.AddWithValue("@datumRazduzenja", i.datumRazduzenja);
                cmd.Parameters.AddWithValue("@Zaposleni_jmb", i.Zaposleni_jmb_zaduzuje);
                cmd.Parameters.AddWithValue("@Zaposleni_jmb1", i.Zaposleni_jmb_razduzuje);
                cmd.Parameters.AddWithValue("@Automobil_idAutomobil1", i.Automobil_idAutomobil);
                cmd.Parameters.AddWithValue("@Iznajmljivac_jmb", i.Iznajmljivac_jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
     
        public List<Iznajmljivanje> getIznajmljivanja(string filter)
        {
            List<Iznajmljivanje> result = new List<Iznajmljivanje>();
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
                    result.Add(new Iznajmljivanje()
                    {
                        idIznajmljivanje = reader.GetInt32(0),
                        Automobil_idAutomobil = reader.GetInt32(1),
                        Automobil_naziv = reader.GetString(2),
                        Iznajmljivac_ime = reader.GetString(3),
                        Iznajmljivac_prezime = reader.GetString(4),
                        Iznajmljivac_jmb = reader.GetString(5),
                        Zaposleni_korisnickoIme_zaduzuje = reader.GetString(6),
                        Zaposleni_jmb_zaduzuje = reader.GetString(7),
                        Zaposleni_KorisnickoIme_razduzuje = reader.GetString(8),
                        Zaposleni_jmb_razduzuje = reader.GetString(9),
                        datumZaduzenja = reader.GetDateTime(10),
                        datumRazduzenja = reader.GetDateTime(11)
                    }); 
                    
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

       

        public DateTime GetVrijemeIznajmljivanja(int idAutomobil)
        {
            DateTime result = new DateTime();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = GETONE;
                cmd.Parameters.AddWithValue("idAutomobil", idAutomobil);
                cmd.Parameters.AddWithValue("vrijemeRaz", DateTime.MinValue);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDateTime(0);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void izbrisiIznajmljivanja(int idAuto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@idAuto", idAuto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlIznajmljivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
