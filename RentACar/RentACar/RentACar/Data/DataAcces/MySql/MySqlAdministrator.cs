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
    public class MySqlAdministrator : IAdministrator
    {
        private static readonly string SELECT = "SELECT korisnickoIme, lozinka, tema, jmb FROM `administrator` ";
        private static readonly string UPDATE = "UPDATE `administrator` SET korisnickoIme=@korisnickoIme, lozinka=@lozinka WHERE jmb=@jmb";
        private static readonly string GETONE = "SELECT korisnickoIme, lozinka, tema, jmb FROM `administrator` WHERE jmb=@jmb";
        private static readonly string UPDATETEMA = "UPDATE `administrator` SET tema=@tema WHERE jmb=@jmb";


        public List<Administrator> getAdministratore()
        {
            List<Administrator> result = new List<Administrator>();
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
                    result.Add(new Administrator()
                    {

                        korisnickoIme = reader.GetString(0),
                        lozinka = reader.GetString(1),
                        tema = reader.GetString(2),
                        jmb = reader.GetString(3)
                    }); 
                    
                    Debug.WriteLine(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAdministrator", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void azurirajAdministratora(Administrator a,string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@korisnickoIme", a.korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", a.lozinka);
                cmd.Parameters.AddWithValue("@jmb", a.jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAdministrator", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public Administrator getOne(string jmb)
        {
            Administrator result = new Administrator();
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
                
                    result=new Administrator()
                    {

                        korisnickoIme = reader.GetString(0),
                        lozinka = reader.GetString(1),
                        tema = reader.GetString(2),
                        jmb = reader.GetString(3)
                    };
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAdministrator", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void azurirajTemu(Administrator a, string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATETEMA;
                cmd.Parameters.AddWithValue("@tema", a.tema);
                cmd.Parameters.AddWithValue("@jmb", a.jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAdministrator", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
           
        }
    }
}
