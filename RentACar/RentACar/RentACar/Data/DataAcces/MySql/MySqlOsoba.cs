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
    public class MySqlOsoba : IOsoba
    {
        private static readonly string INSERT = "INSERT INTO `osoba`(jmb, ime, prezime, brojTelefona, email) VALUES (@jmb, @ime, @prezime, @brojTelefona, @email)";
        private static readonly string UPDATE = "UPDATE `osoba` SET ime=@ime, prezime=@prezime, brojTelefona=@brojTelefona, email=@email WHERE jmb=@jmb";
        private static readonly string DELETE = "DELETE FROM `osoba` WHERE jmb=@jmb";
        private static readonly string GETONE = "SELECT jmb, ime, prezime, brojTelefona,email FROM `osoba` WHERE jmb=@jmb";

        public void addOsoba(Osoba o)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@jmb", o.jmb);
                cmd.Parameters.AddWithValue("@ime", o.ime);
                cmd.Parameters.AddWithValue("@prezime", o.prezime);
                cmd.Parameters.AddWithValue("@brojTelefona", o.brojTelefona);
                cmd.Parameters.AddWithValue("@email", o.email);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void azurirajOsobu(Osoba o)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@ime", o.ime);
                cmd.Parameters.AddWithValue("@prezime", o.prezime);
                cmd.Parameters.AddWithValue("@brojTelefona", o.brojTelefona);
                cmd.Parameters.AddWithValue("@email", o.email);
                cmd.Parameters.AddWithValue("@jmb", o.jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void izbrisiOsobu(string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@jmb", jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        Osoba IOsoba.getOne(string jmb)
        {
            Osoba result = new Osoba();
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
                if (reader.Read())
                {
                    result = new Osoba()
                    {
                        jmb = reader.GetString(0),
                        ime = reader.GetString(1),
                        prezime = reader.GetString(2),
                        brojTelefona = reader.GetString(3),
                        email = reader.GetString(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
