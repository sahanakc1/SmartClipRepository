using BusinessLayer.Models;
using DataLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Repositorytblcheckins
    {
        public bool postObjectToDatabase(CheckinModel checkinModel)
        {
            tblcheckin checkin = new tblcheckin();

            using (saloondbEntities DBModel = new saloondbEntities())
            {
                DBModel.checkins.Add(new tblcheckin { 
                checkin_time = checkinModel.checkin_time,
                saloon_id = checkinModel.saloon_id,
                role_id = checkinModel.role_id,
                user_id = checkinModel.user_id
                });
                DBModel.SaveChanges();
            }

            return true;
        }
    }
}
