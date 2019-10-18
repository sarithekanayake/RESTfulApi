using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using IMAGINaryApi.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace IMAGINaryApi
{
    public class DeveloperConfig
    {

        public Developer getDevelopers(int id)
        {
            SqlConnection conn = new SqlConnection();
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

            try
            {
                conn.ConnectionString = myConnetionString;
                conn.Open();
                SqlDataReader developersReader = null;
                string sqlString = "SELECT employees.EMP_Name,SUM(tasks.Over_Time) FROM employees JOIN tasks ON tasks.Developer = employees.EMP_ID where employees.EMP_ID = "+id.ToString()+" Group by employees.EMP_Name ";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                Developer dev = new Developer();
                developersReader = cmd.ExecuteReader();
                if (developersReader.Read())
                {
                    if ((developersReader.IsDBNull(0)) || (developersReader.IsDBNull(1)))
                    {
                        return null;
                    }
                    else
                    {
                        dev.Name = developersReader.GetString(0);
                        dev.OverTime = developersReader.GetInt32(1);
                        return dev;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}