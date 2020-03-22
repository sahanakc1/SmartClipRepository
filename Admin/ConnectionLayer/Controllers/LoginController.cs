using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Models;
using BusinessLayer;
using DataLayer.EntityModel;
using Newtonsoft.Json;

namespace ConnectionLayer.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/values
        
        [HttpGet]
        public IHttpActionResult GetSaloonDetails()
        {
            List<SaloonUserModel> saloonusers = null;
            saloonusers = GetObjectsFromDatabase.GetTblSaloonusers();

            var sallon = JsonConvert.SerializeObject(saloonusers);
            // serialize into json string

            return Ok(saloonusers);
        }

        [HttpGet]
        public IHttpActionResult GetUserDetails()
        {
            List<UserModel> users = null;
            users = GetObjectsFromDatabase.GetTblusers();

            var sallon = JsonConvert.SerializeObject(users);
            // serialize into json string

            return Ok(users);
        }

        [HttpGet]
        public IHttpActionResult GetCheckinDetails()
        {
            List<CheckinModel> checkins = null;
            checkins = GetObjectsFromDatabase.GetTblCheckins();

            var sallon = JsonConvert.SerializeObject(checkins);
            // serialize into json string

            return Ok(checkins);
        }

        [HttpPost]
        public IHttpActionResult PostNewUser(UserModel user)
        {

            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
          
            return Ok();
        }
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
