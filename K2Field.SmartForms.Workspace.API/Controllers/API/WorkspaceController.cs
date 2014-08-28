using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace K2Field.SmartForms.Workspace.API.Controllers.API
{
    public class WorkspaceController : ApiController
    {
        Model.ApplicationUnit _unit = new Model.ApplicationUnit();

        [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials=true)]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_unit.Workspaces.All());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        // GET: api/test/5
        [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
        public IHttpActionResult Get(Guid id)
        {
            Data.Workspace w = null;

            try
            {
                w = _unit.Workspaces.Find(id);

                if (w == null)
                {
                    return NotFound();
                }

                return Ok(w);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.InnerException.Message);
                }
                else if (ex.Message != null)
                {
                    return BadRequest(ex.Message);
                }
                else
                {
                    return BadRequest("something bad");
                }
            }

        }


    }
}

