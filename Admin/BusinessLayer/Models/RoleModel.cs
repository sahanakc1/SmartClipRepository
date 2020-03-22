using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class RoleModel
    {
        public int id { get; set; }
        public string role { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    }
}
