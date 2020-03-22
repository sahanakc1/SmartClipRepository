using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EntityModel;

namespace DataLayer
{
    public class Roles
    {
        public static List<tblrole> GetTblRoles()
        {
            List<tblrole> roles = null;
            using (saloondbEntities DBModel = new saloondbEntities())
            {
                roles = (from p in DBModel.roles select p).ToList<tblrole>();
            }
            return roles;
        }
    }
}
