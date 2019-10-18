using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IMAGINaryApi.Models;
using System.Collections;


namespace IMAGINaryApi.Controllers
{
    public class tasksController : ApiController
    {
        // GET: api/tasks/2
        public ArrayList Get(int id)
        {
            TasksConfig tasks = new TasksConfig();
            return tasks.getTasks(id);
        }

        // POST: api/tasks
        public HttpResponseMessage Post([FromBody]Task value)
        {
            TasksConfig task = new TasksConfig();
            int lastindex = task.postTask(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("tasks/{0}", lastindex));
            return response;
        }

        // PUT: api/tasks/5
        public HttpResponseMessage Put(int id, [FromBody]Task value)
        {
            TasksConfig task = new TasksConfig();
            bool recordExisted = false;
            recordExisted = task.updateTask(id, value);
            HttpResponseMessage response;

            if (recordExisted)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return response;
        }

        // DELETE: api/tasks/5
        public HttpResponseMessage Delete(int id)
        {
            TasksConfig task = new TasksConfig();
            bool recordExisted = false;
            recordExisted = task.deleteTask(id);
            HttpResponseMessage response;

            if (recordExisted)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return response;
        }
    }
}
