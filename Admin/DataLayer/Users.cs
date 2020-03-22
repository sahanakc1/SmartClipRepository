using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EntityModel;

namespace DataLayer
{
    public class Users
    {
        public static List<tbluser> GetTblusers()
        {
            List<tbluser> users = null;
            using(saloondbEntities DBModel = new saloondbEntities())
            {
                users = DBModel.users.Include("tblcheckin").Include("tblrole").ToList<tbluser>();
            }
            return users;
        }
    }
}
