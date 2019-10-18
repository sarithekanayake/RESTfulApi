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
    public class TasksConfig
    {
        public ArrayList getTasks(int id)
        {
            SqlConnection conn = new SqlConnection();
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            try
            {
                conn.ConnectionString = myConnetionString;
                conn.Open();
                ArrayList tasksArray = new ArrayList();
                SqlDataReader tasksReader = null;
                string sqlString = "SELECT t.Task_ID,t.Project,p.Project_Name,t.Task_Desc,t.Task_Date,t.Working_Hours,t.Over_Time FROM tasks t JOIN projects p ON t.Project = p.P_ID WHERE t.Developer = " + id.ToString();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                tasksReader = cmd.ExecuteReader();
                while (tasksReader.Read())
                {
                    Task t = new Task();
                    if ((tasksReader.IsDBNull(0)) || (tasksReader.IsDBNull(1)) || (tasksReader.IsDBNull(2)) || (tasksReader.IsDBNull(3))|| (tasksReader.IsDBNull(4))|| (tasksReader.IsDBNull(5))|| (tasksReader.IsDBNull(6)))
                    {
                        t.Developer_ID = id;
                        t.Task_ID = 0;
                        t.Project_ID = 0;
                        t.Project_Name = "Null";
                        t.Task_Description = "Null";
                        t.Task_Date = tasksReader.GetDateTime(4);
                        t.Working_Hours = 0;
                        t.Over_Time = 0;
                        tasksArray.Add(t);
                    }
                    else
                    {
                        t.Developer_ID = id;
                        t.Task_ID = tasksReader.GetInt32(0);
                        t.Project_ID = tasksReader.GetInt32(1);
                        t.Project_Name = tasksReader.GetString(2);
                        t.Task_Description = tasksReader.GetString(3);
                        t.Task_Date = tasksReader.GetDateTime(4);
                        t.Working_Hours = tasksReader.GetInt32(5);
                        t.Over_Time = tasksReader.GetInt32(6);
                        tasksArray.Add(t);
                    }
                }
                tasksReader.Close();
                return tasksArray;
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

        public int postTask(Task taskToSave)
        {
            SqlConnection conn = new SqlConnection();
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            try
            {
                conn.ConnectionString = myConnetionString;
                conn.Open();
                string sqlString = "INSERT into tasks (Developer,Project,Task_Desc,Task_Date,Working_Hours,Over_Time) OUTPUT INSERTED.Task_ID values (" + taskToSave.Developer_ID + "," + taskToSave.Project_ID + ",'" + taskToSave.Task_Description + "','" + taskToSave.Task_Date.ToString("yyyy-MM-dd") + "'," + taskToSave.Working_Hours + "," + taskToSave.Over_Time + ")";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                Int32 id = (Int32)cmd.ExecuteScalar();
                return id;
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

        public bool updateTask(int id, Task taskToSave)
        {
            SqlConnection conn = new SqlConnection();
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            try
            {
                conn.ConnectionString = myConnetionString;
                conn.Open();
                SqlDataReader taskReader = null;
                String sqlString = "SELECT * from tasks where Task_ID = " + id.ToString();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                taskReader = cmd.ExecuteReader();
                if (taskReader.Read())
                {
                    taskReader.Close();
                    sqlString = "UPDATE tasks SET Task_Date= '" + taskToSave.Task_Date.ToString("yyyy-MM-dd") + "', Working_Hours=" + taskToSave.Working_Hours + " WHERE Task_ID = " + id.ToString();
                    cmd = new SqlCommand(sqlString, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
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

        public bool deleteTask(int id)
        {
            SqlConnection conn = new SqlConnection();
            string myConnetionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            try
            {
                conn.ConnectionString = myConnetionString;
                conn.Open();
                SqlDataReader taskReader = null;
                String sqlString = "SELECT * from tasks where Task_ID = " + id.ToString();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                taskReader = cmd.ExecuteReader();
                if (taskReader.Read())
                {
                    taskReader.Close();
                    sqlString = "DELETE from tasks WHERE Task_ID = " + id.ToString();
                    cmd = new SqlCommand(sqlString, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
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