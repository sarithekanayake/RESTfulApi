using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using IMAGINaryClient.Models;

namespace IMAGINaryClient
{
    public partial class DeveloperUI : Form
    {
        int devid = 0;
        bool pro, desc, hrs, ovr,tskup,hrsup,tskdlt;

        public DeveloperUI(int id)
        {
            InitializeComponent();
            devid = id;
        }

        /// <summary>
        /// Add task tab configurations
        /// </summary>
        private void txtProject_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtProject.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtProject.Text))
            {
                epProject.Clear();
                pro = true;
            }
            else
            {
                epProject.SetError(txtProject, "Check Project ID!");
                pro = false;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                epDesc.Clear();
                desc = true;
            }
            else
            {
                epDesc.SetError(txtDescription, "Please add Description!");
                desc = false;
            }
        }

        private void txtWorkingHours_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtWorkingHours.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtWorkingHours.Text))
            {
                epHours.Clear();
                hrs = true;
            }
            else
            {
                epHours.SetError(txtWorkingHours, "Check Working Hours!");
                hrs = false;
            }
        }

        private void txtOverTime_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtOverTime.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtOverTime.Text))
            {
                epOver.Clear();
                ovr = true;
            }
            else
            {
                epOver.SetError(txtOverTime, "Check Over Time!");
                ovr = false;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (pro && desc && hrs && ovr)
            {
                epProject.Clear();
                epDesc.Clear();
                epHours.Clear();
                epOver.Clear();
                Tasks nwtsk = new Tasks() { Developer_ID = devid, Project_ID = Convert.ToInt32(txtProject.Text), Task_Description = txtDescription.Text, Task_Date = dtpWorkDate.Value, Working_Hours = Convert.ToInt32(txtWorkingHours.Text), Over_Time = Convert.ToInt32(txtOverTime.Text) };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:51060/");
                HttpResponseMessage response = client.PostAsJsonAsync("api/tasks", nwtsk).Result;

                if (response.IsSuccessStatusCode)
                {
                    Uri personUrl = response.Headers.Location;
                    MessageBox.Show("Inserted Data Successfully!\nLocation : " + personUrl.ToString());
                    txtProject.Clear();
                    txtDescription.Clear();
                    dtpWorkDate.Value = DateTime.Today;
                    txtWorkingHours.Clear();
                    txtOverTime.Clear();
                }
                else
                {
                    MessageBox.Show("Insert Data not Successful!");
                }
            }
            else
            {
                MessageBox.Show("Insert Data not Successful!\nCheck Values!");
            }
        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            txtProject.Clear();
            txtDescription.Clear();
            dtpWorkDate.Value = DateTime.Today;
            txtWorkingHours.Clear();
            txtOverTime.Clear();
        }

        /// <summary>
        /// View Tasks tab Configurations
        /// </summary>
        private void btnTasksView_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51060/");
            HttpResponseMessage response = client.GetAsync("api/tasks/" + devid.ToString()).Result;
            var get_tsks = response.Content.ReadAsAsync<IEnumerable<TasksToView>>().Result;
            dgvTasks.DataSource = get_tsks;
        }

        /// <summary>
        /// Edit Task tab Update Configurations
        /// </summary
        private void txtSearchTaskID_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtSearchTaskID.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtSearchTaskID.Text))
            {
                epTaskIDUp.Clear();
                tskup = true;
            }
            else
            {
                epTaskIDUp.SetError(txtSearchTaskID, "Check Over Time!");
                tskup = false;
            }
        }

        private void txtHoursUpdate_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtHoursUpdate.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtHoursUpdate.Text))
            {
                epHrsUp.Clear();
                hrsup = true;
            }
            else
            {
                epHrsUp.SetError(txtHoursUpdate, "Check Over Time!");
                hrsup = false;
            }
        }
        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if(tskup&& hrsup)
            {
                Tasks uptsk = new Tasks() { Task_Date = dtpDateUpdate.Value, Working_Hours = Convert.ToInt32(txtHoursUpdate.Text) };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:51060/");
                HttpResponseMessage response = client.PutAsJsonAsync("api/tasks/" + txtSearchTaskID.Text, uptsk).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update record " + txtSearchTaskID.Text + " is Successful!");
                    txtSearchTaskID.Clear();
                    dtpDateUpdate.Value = DateTime.Today;
                    txtHoursUpdate.Clear();
                }
                else
                {
                    MessageBox.Show("Update record " + txtSearchTaskID.Text + " is not Successful!");
                }
            }
            else
            {
                MessageBox.Show("Check field values!");
            }
        }

        private void btnClearTaskUp_Click(object sender, EventArgs e)
        {
            txtSearchTaskID.Clear();
            dtpDateUpdate.Value = DateTime.Today;
            txtHoursUpdate.Clear();
        }

        /// <summary>
        /// Edit Task tab Delete configurations
        /// </summary>

        private void txtDeleteTask_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtDeleteTask.Text, out dig);
            if (isNum && !string.IsNullOrEmpty(txtDeleteTask.Text))
            {
                epTaskIDDlt.Clear();
                tskdlt = true;
            }
            else
            {
                epTaskIDDlt.SetError(txtSearchTaskID, "Check Task ID!");
                tskdlt = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tskdlt)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:51060/");
                HttpResponseMessage response = client.DeleteAsync("api/tasks/" + txtDeleteTask.Text).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Delete record " + txtDeleteTask.Text + " is Successful!");
                    txtDeleteTask.Clear();
                }
                else
                {
                    MessageBox.Show("Delete record " + txtDeleteTask.Text + " is not Successful,\nCheck Task ID again!");
                }
            }
            else
            {
                MessageBox.Show("Check Task ID value!");
            }
        }
    }
}
