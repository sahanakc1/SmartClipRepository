using BusinessLayer.Models;
using DataLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
   public class RepositorytblUsers
    {
        public bool postObjectToDatabase(UserModel users)
        {
            tbluser checkin = new tbluser();

            using (saloondbEntities DBModel = new saloondbEntities())
            {
                DBModel.users.Add(new tbluser
                {
                   name = users.name,
                    password = users.password,
                    phone = users.phone,
                    Address = users.Address,
                    email = users.email,
                    zipcode = users.zipcode,
                    role_id = users.role_id
                });
                DBModel.SaveChanges();
            }

            return true;
        }
    }
}
