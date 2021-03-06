﻿using System;
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
        public IHttpActionResult Get([FromUri] string username)
        {
            string us = username.ToString();

            string u = us.Replace("_s_", @"\");
            try
            {
                Data.WorkspaceUser user = _unit.WorkspaceUsers.Find(u);
                if (user != null)
                {
                    return Ok(user);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
