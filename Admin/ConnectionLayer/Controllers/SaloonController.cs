using BusinessLayer;
using BusinessLayer.Models;
using BusinessLayer.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConnectionLayer.Controllers
{
    public class SaloonController : ApiController
    {
        [System.Web.Http.HttpPost]
        public bool PostCheckinDetails([FromBody]Object value)
        {
            //dynamic json = new JObject();
            string jsonString = JsonConvert.SerializeObject(value);
            var res = JArray.Parse(jsonString);
           // CheckinModel checkin = JsonConvert.DeserializeObject<CheckinModel>(res);
            List<CheckinModel> checkin = JsonConvert.DeserializeObject<List<CheckinModel>>(res.ToString());


            Repositorytblcheckins repositorytblcheckins = new Repositorytblcheckins();
            return repositorytblcheckins.postObjectToDatabase(checkin[0]);
        }

        [System.Web.Http.HttpPost]
        public bool PostCreateUsers([FromBody]Object value)
        {
            //dynamic json = new JObject();
            string jsonString = JsonConvert.SerializeObject(value);
            var res = JArray.Parse(jsonString);
            // CheckinModel checkin = JsonConvert.DeserializeObject<CheckinModel>(res);
            List<UserModel> users = JsonConvert.DeserializeObject<List<UserModel>>(res.ToString());

            RepositorytblUsers repositorytblcheckins = new RepositorytblUsers();
            return repositorytblcheckins.postObjectToDatabase(users[0]);
        }
    }
}
