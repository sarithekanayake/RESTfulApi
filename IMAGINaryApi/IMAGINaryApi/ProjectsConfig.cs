using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMAGINaryApi.Models;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace IMAGINaryApi
{
    public class ProjectsConfig
    {
        SqlConnection conn = new SqlConnection();
        SqlConnection conn2 = new SqlConnection();
        ArrayList projectArray = new ArrayList();
        public ArrayList getProject(int id)
        {
            
            
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            try
            {
                conn.ConnectionString = myConnetionString;
                conn2.ConnectionString = myConnetionString;
                conn.Open();
                conn2.Open();
                SqlDataReader projectsReader = null;
                string sqlString = "SELECT p.P_ID,p.Project_Name,p.Developer,p.Tot_Hours FROM employees e JOIN projects p ON e.EMP_ID = p.Manager where p.Manager = "+id.ToString();
                SqlCommand cmd = new SqlCommand(sqlString,conn);
                projectsReader = cmd.ExecuteReader();
                while (projectsReader.Read())
                {
                    Projects p = new Projects();
                    if ((projectsReader.IsDBNull(0)) || (projectsReader.IsDBNull(1))|| (projectsReader.IsDBNull(2)))
                    {
                        p.Project = "No Projects are available";
                        p.Developer = "No Developers are assigned";
                        p.Hours = 0;
                        p.Overtime = 0;
                        p.Contribution = "0 %";
                        projectArray.Add(p);
                    }
                    else
                    {
                        int pid = projectsReader.GetInt32(0);
                        string proname = projectsReader.GetString(1);
                        string devs = projectsReader.GetString(2);
                        double hrs = projectsReader.GetInt32(3);
                        string[] devidarray = devs.Split(',');   
                        for(int i = 0 ; i<devidarray.Length;i++)
                        {
                            tasksToView(devidarray[i],pid,proname,hrs);

                        }

                    }
                }
                projectsReader.Close();
                return projectArray;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn2.Close();
            }
        }

        private void tasksToView(string devids,int pro,string pname,double phrs)
        {
            string sqlString2 = "SELECT  e.EMP_Name,SUM(t.Working_Hours) as Working_Hours,SUM(t.Over_Time) as Over_Time FROM employees e JOIN tasks t ON e.EMP_ID = t.Developer where t.Developer = " +devids+ " and t.Project = "+pro+" GROUP BY e.EMP_Name";
            SqlCommand cmd2 = new SqlCommand(sqlString2, conn2);
            SqlDataReader developersReader = null; 
            developersReader = cmd2.ExecuteReader();
            if (developersReader.Read())
            {
                Projects p = new Projects();
                p.Project = pname;
                p.Developer = developersReader.GetString(0);
                p.Hours = developersReader.GetInt32(1);
                p.Contribution = ((developersReader.GetInt32(1) / phrs) * 100).ToString()+" %";
                p.Overtime = developersReader.GetInt32(2);
                projectArray.Add(p);
            }
        }
    }
}