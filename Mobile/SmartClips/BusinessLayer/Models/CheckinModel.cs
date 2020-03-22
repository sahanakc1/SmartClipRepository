using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class CheckinModel
    {
        public int id { get; set; }
        public Nullable<System.DateTime> checkin_time { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public int saloon_id { get; set; }
        public int user_id { get; set; }
        public int role_id { get; set; }
        public string role { get; set; }
        public string uname { get; set; }
        public string uphone { get; set; }
        public string uAddress { get; set; }
        public string uemail { get; set; }
        public string uzipcode { get; set; }

        public string sname { get; set; }
        public string sphone { get; set; }
        public string sAddress { get; set; }
        public string semail { get; set; }
        public string szipcode { get; set; }
        public string saloon_name { get; set; }
        public Nullable<System.TimeSpan> businesshrs_from { get; set; }
        public Nullable<System.TimeSpan> businesshrs_to { get; set; }
       
    }
}
