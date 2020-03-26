using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class SaloonUserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public string zipcode { get; set; }
        public string saloon_name { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public int role_id { get; set; }
        public Nullable<System.TimeSpan> businesshrs_from { get; set; }
        public Nullable<System.TimeSpan> businesshrs_to { get; set; }
        public string role { get; set; }

        public double lattitude { get; set; }
        public double longitude { get; set; }
    }
}
