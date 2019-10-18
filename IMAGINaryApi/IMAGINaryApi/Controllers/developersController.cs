using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IMAGINaryApi.Models;

namespace IMAGINaryApi.Controllers
{
    public class developersController : ApiController
    {
        /// <summary>
        /// Get a specific developer by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        // GET: api/developers/5
        public HttpResponseMessage Get(int id)
        {
            DeveloperConfig devcon = new DeveloperConfig();
            Developer develop = devcon.getDevelopers(id);
            HttpResponseMessage response = null;

            if (develop == null)
            {
                response = new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, develop);
            }

            return response;
        }


    }



}
