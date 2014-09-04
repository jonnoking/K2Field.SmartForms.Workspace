using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Cors;

namespace K2Field.SmartForms.Workspace.API.Controllers.API
{
    public class IdentityController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(GetIdentiy());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public class Identity
        {
            public string IdentityName { get; set; }
            public bool IsAuthenticated { get; set; }
            public string AuthenticationType { get; set; }
            public List<ViewClaim> Claims { get; set; }
        }

        public class ViewClaim
        {
            public string Type { get; set; }
            public string Value { get; set; }
        }

        private  Identity GetIdentiy()
        {
            var principal = ClaimsPrincipal.Current;

            Identity i = new Identity();
            if (principal != null && principal.Identity != null)
            {
                i.IdentityName = principal.Identity.Name;
                i.IsAuthenticated = principal.Identity.IsAuthenticated;
                i.AuthenticationType = principal.Identity.AuthenticationType;
            }
            else
            {
                i.IsAuthenticated = false;
            }

            var claims = new List<ViewClaim>(
                from c in principal.Claims
                select new ViewClaim
                {
                    Type = c.Type,
                    Value = c.Value
                });

            i.Claims = claims;

            return i;
        }
 
    }
}
