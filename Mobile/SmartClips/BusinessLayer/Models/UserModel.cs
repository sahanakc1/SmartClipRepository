using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public string zipcode { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public int role_id { get; set; }
        public string role { get; set; }
    }
}
