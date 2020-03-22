using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EntityModel;

namespace DataLayer
{
    public class SaloonUsers
    {
        public static List<tblsaloonuser> GetTblSaloonusers()
        {
            List<tblsaloonuser> users = null;
            using (saloondbEntities DBModel = new saloondbEntities())
            {
                DBModel.Configuration.ProxyCreationEnabled = false;
                users = DBModel.saloonusers.Include("tblcheckins").Include("tblrole").ToList<tblsaloonuser>();
            }
            return users;
        }
    }
}
