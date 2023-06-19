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
    public class MySqlAutomobil : IAutomobil
    {
        private static readonly string SELECT = "SELECT naziv ,sjedista, godinaProizvodnje, gorivo, transmisija, cijena, idAutomobil,zaduzen FROM `automobil` WHERE naziv LIKE @str ORDER BY naziv";
        private static readonly string GETONE = "SELECT naziv, kubikaza, potrosnja, gorivo, transmisija, godinaProizvodnje, kapacitetRezervoara, konjskihSnaga, sjedista, cijena, zaduzen, idAutomobil, Administrator_jmb, putanja_do_slike FROM `automobil` WHERE idAutomobil=@idAutomobil";
        private static readonly string INSERT = "INSERT INTO `automobil` (naziv, kubikaza, potrosnja, gorivo, transmisija, godinaProizvodnje, kapacitetRezervoara, konjskihSnaga, sjedista, cijena, zaduzen, Administrator_jmb, putanja_do_slike) VALUES (@naziv, @kubikaza, @potrosnja, @gorivo, @transmisija, @godinaProizvodnje, @kapacitetRezervoara, @konjskihSnaga, @sjedista, @cijena, @zaduzen, @jmb, @putanjaDoSlike)";
        private static readonly string UPDATE = "UPDATE `automobil` SET naziv=@naziv, kubikaza=@kubikaza, potrosnja=@potrosnja, gorivo=@gorivo, transmisija=@transmisija, godinaProizvodnje=@godinaProizvodnje, kapacitetRezervoara=@kapacitetRezervoara, konjskihSnaga=@konjskihSnaga, sjedista = @sjedista,cijena=@cijena ,zaduzen = @zaduzen , Administrator_jmb = @jmb WHERE idAutomobil=@idAutomobil";
        private static readonly string DELETE = "DELETE FROM `automobil` WHERE idAutomobil=@idAutomobil";

        public List<Automobil> getAutomobile(string filter)
        {
            List<Automobil> result = new List<Automobil>();
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
                    result.Add(new Automobil()
                    {
                        naziv = reader.GetString(0),
                        gorivo = reader.GetString(3),
                        transmisija = reader.GetString(4),
                        godinaProizvodnje = reader.GetString(2),
                        brojSjedista = reader.GetInt32(1),
                        cijena = reader.GetDouble(5),
                        idAutomobil = reader.GetInt32(6),
                        zaduzen = reader.GetInt32(7)
                    }) ;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAutomobil", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void dodajAutomobil(Automobil a)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {   
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@naziv", a.naziv);
                cmd.Parameters.AddWithValue("@kubikaza", a.kubikaza);
                cmd.Parameters.AddWithValue("@potrosnja", a.potrosnja);
                cmd.Parameters.AddWithValue("@gorivo", a.gorivo);
                cmd.Parameters.AddWithValue("@transmisija", a.transmisija);
                cmd.Parameters.AddWithValue("@godinaProizvodnje", a.godinaProizvodnje);
                cmd.Parameters.AddWithValue("@kapacitetRezervoara", a.kapacietetRezervoara);
                cmd.Parameters.AddWithValue("@konjskihSnaga", a.konjskihSnaga);
                cmd.Parameters.AddWithValue("@sjedista", a.brojSjedista);
                cmd.Parameters.AddWithValue("@cijena", a.cijena);
                cmd.Parameters.AddWithValue("@zaduzen", a.zaduzen);
                cmd.Parameters.AddWithValue("@jmb", a.Administrator_jmb);
                cmd.Parameters.AddWithValue("@putanjaDoSlike", a.putanjaDoSlike);
                Debug.WriteLine(a.putanjaDoSlike);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAutomobil", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void azurirajAutomobil(Automobil a)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@naziv", a.naziv);
                cmd.Parameters.AddWithValue("@kubikaza", a.kubikaza);
                cmd.Parameters.AddWithValue("@potrosnja", a.potrosnja);
                cmd.Parameters.AddWithValue("@gorivo", a.gorivo);
                cmd.Parameters.AddWithValue("@transmisija", a.transmisija);
                cmd.Parameters.AddWithValue("@godinaProizvodnje", a.godinaProizvodnje);
                cmd.Parameters.AddWithValue("@kapacitetRezervoara", a.kapacietetRezervoara);
                cmd.Parameters.AddWithValue("@konjskihSnaga", a.konjskihSnaga);
                cmd.Parameters.AddWithValue("@sjedista", a.brojSjedista);
                cmd.Parameters.AddWithValue("@cijena", a.cijena);
                cmd.Parameters.AddWithValue("@zaduzen", a.zaduzen);
                cmd.Parameters.AddWithValue("@jmb", a.Administrator_jmb);
                cmd.Parameters.AddWithValue("@idAutomobil", a.idAutomobil);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAutomobil", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void obrisiAutomobil(int idAutomobil)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@idAutomobil", idAutomobil);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAutomobil", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Automobil getOne(int idAutomobil)
        {
            Automobil result = new Automobil();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = GETONE;
                cmd.Parameters.AddWithValue("@idAutomobil", idAutomobil);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result=new Automobil()
                    {
                        naziv = reader.GetString(0),
                        kubikaza = reader.GetDouble(1),
                        potrosnja = reader.GetString(2),
                        gorivo = reader.GetString(3),
                        transmisija = reader.GetString(4),
                        godinaProizvodnje = reader.GetString(5),
                        kapacietetRezervoara = reader.GetDouble(6),
                        konjskihSnaga = reader.GetDouble(7),
                        brojSjedista = reader.GetInt32(8),
                        cijena = reader.GetDouble(9),
                        zaduzen = reader.GetInt32(10),
                        idAutomobil = reader.GetInt32(11),
                        Administrator_jmb = reader.GetString(12),
                        putanjaDoSlike = reader.GetString(13)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAutomobil", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
