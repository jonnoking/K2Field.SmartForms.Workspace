using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace K2Field.SmartForms.Workspace.API.Controllers.API
{
    public class WorkspaceUserController : ApiController
    {
        Model.ApplicationUnit _unit = new Model.ApplicationUnit();

        [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_unit.WorkspaceUsers.All());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
        public IHttpActionResult Get(string username)
        {
            string u = username.Replace("_s_", @"\");
            try
            {
                return Ok(_unit.WorkspaceUsers.Find(u));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
