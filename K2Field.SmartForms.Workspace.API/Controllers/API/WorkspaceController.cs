﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace K2Field.SmartForms.Workspace.API.Controllers.API
{
    public class WorkspaceController : ApiController
    {
        Model.ApplicationUnit _unit = new Model.ApplicationUnit();

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
                    //throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message));
                    return BadRequest(ex.InnerException.Message);
                }
                else if (ex.Message != null)
                {
                    //throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message));
                    return BadRequest(ex.Message);
                }
                else
                {
                    //throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, "something bad"));
                    return BadRequest("something bad");
                }
            }

        }


    }
}

