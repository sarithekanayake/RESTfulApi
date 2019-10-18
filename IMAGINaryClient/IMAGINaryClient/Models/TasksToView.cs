using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAGINaryClient.Models
{
    class TasksToView
    {
        public int Task_ID { get; set; }
        public int Project_ID { get; set; }
        public string Project_Name { get; set; }
        public string Task_Description { get; set; }
        public DateTime Task_Date { get; set; }
        public int Working_Hours { get; set; }
        public int Over_Time { get; set; }
    }
}
