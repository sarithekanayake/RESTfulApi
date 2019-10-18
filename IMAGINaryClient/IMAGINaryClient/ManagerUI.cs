using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Windows.Forms;
using IMAGINaryClient.Models;
using System.Collections;

namespace IMAGINaryClient
{
    public partial class ManagerUI : Form
    {
        int managerid;
        bool devokay;
        public ManagerUI(int id)
        {
            InitializeComponent();
            managerid = id;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51060/");
            HttpResponseMessage response = client.GetAsync("api/projects/"+managerid.ToString()).Result;
            var pro = response.Content.ReadAsAsync<IEnumerable<Projects>>().Result;
            dgvProjects.DataSource = pro;
        }


        private void txtDevID_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtDevID.Text, out dig);
            if ((isNum) && !string.IsNullOrEmpty(txtDevID.Text))
            {
                epDev.Clear();
                devokay = true;
            }
            else
            {
                epDev.SetError(txtDevID, "Check Developer ID!");
                devokay = false;
            }
        }

        private void btnDevelopers_Click(object sender, EventArgs e)
        {
            if (devokay)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:51060/");
                HttpResponseMessage response = client.GetAsync("api/developers/" + txtDevID.Text).Result;
                Models.Developer dev = response.Content.ReadAsAsync<Models.Developer>().Result;
                List<Models.Developer> devlist = new List<Models.Developer>();
                devlist.Add(dev);
                dgvDevelopers.DataSource = devlist;
            }
            else
            {
                MessageBox.Show("Check Developer ID!");
            }
        }
    }
}
