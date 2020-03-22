using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EntityModel;

namespace DataLayer
{
    public class CheckinDetails
    {
        public static List<tblcheckin> GetTblCheckins()
        {
            List<tblcheckin> checkins = null;
            using (saloondbEntities DBModel = new saloondbEntities())
            {
                checkins = (from p in DBModel.checkins select p).ToList<tblcheckin>();
            }
            return checkins;
        }
    }
}
