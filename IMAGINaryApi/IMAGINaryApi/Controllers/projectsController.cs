using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
namespace IMAGINaryApi.Controllers
{
    public class projectsController : ApiController
    {
        /// <summary>
        /// Get all the projects of a particular manager 
        /// Need to enter the manager id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/projects/2
        public ArrayList Get(int id)
        {           
            ProjectsConfig projects = new ProjectsConfig();
            return projects.getProject(id);           
        }
    }
}
