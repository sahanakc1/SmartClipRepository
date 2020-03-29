using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EntityModel;
using DataLayer;
using BusinessLayer.Models;

namespace BusinessLayer
{
   public class GetObjectsFromDatabase
    {
        public static List<RoleModel> GetTblRoles()
        {
            List<RoleModel> roleModels = new List<RoleModel>();
            List<tblrole> role = Roles.GetTblRoles();
           
            foreach (var item in role)
            {
                RoleModel roleModel = new RoleModel();
                roleModel.id = item.id;
                roleModel.role = item.role;
                roleModel.created_at = item.created_at;
                roleModel.updated_at = item.updated_at;
                roleModels.Add(roleModel);
            }
            return roleModels;
        }
        public static List<CheckinModel> GetTblCheckins()
        {
            List<CheckinModel> checkinModels = new List<CheckinModel>();
            List<tblcheckin> checkin= CheckinDetails.GetTblCheckins();
           
            foreach (var item in checkin)
            {
                CheckinModel checkinModel = new CheckinModel();
                checkinModel.id = item.id;
                checkinModel.checkin_time = item.checkin_time;
                checkinModel.saloon_id = item.saloon_id;
                checkinModel.role_id = item.role_id;
                checkinModel.user_id = item.user_id;
                checkinModel.uname = item.tbluser.name;
                checkinModel.uphone = item.tbluser.phone;
                checkinModel.uAddress = item.tbluser.Address;
                checkinModel.uemail = item.tbluser.email;
                checkinModel.uzipcode = item.tbluser.zipcode;
                checkinModel.sname = item.tblsaloonuser.name;
                checkinModel.sphone = item.tblsaloonuser.phone;
                checkinModel.sAddress = item.tblsaloonuser.Address;
                checkinModel.semail = item.tblsaloonuser.email;
                checkinModel.szipcode = item.tblsaloonuser.zipcode;
                checkinModel.saloon_name = item.tblsaloonuser.saloon_name;
                checkinModel.businesshrs_from = item.tblsaloonuser.businesshrs_from;
                checkinModel.businesshrs_to = item.tblsaloonuser.businesshrs_to;
                checkinModel.role = item.tblrole.role;
                checkinModel.created_at = item.created_at;
                checkinModel.updated_at = item.updated_at;
                checkinModels.Add(checkinModel);

            }
            return checkinModels;
        }
        public static List<SaloonUserModel> GetTblSaloonusers()
        {
            List<SaloonUserModel> saloonModels = new List<SaloonUserModel>();
            List<tblsaloonuser> suser= SaloonUsers.GetTblSaloonusers();
            
            foreach (var item in suser)
            {
                SaloonUserModel saloonModel = new SaloonUserModel();
                saloonModel.id = item.id;
                saloonModel.role = item.tblrole.role;
                saloonModel.name = item.name;
                saloonModel.password = item.password;
                saloonModel.phone = item.phone;
                saloonModel.Address = item.Address;
                saloonModel.email = item.email;
                saloonModel.zipcode = item.zipcode;
                saloonModel.saloon_name = item.saloon_name;
                saloonModel.businesshrs_from = item.businesshrs_from;
                saloonModel.businesshrs_to = item.businesshrs_to;
                saloonModel.created_at = item.created_at;
                saloonModel.updated_at = item.updated_at;
                saloonModel.role_id = item.role_id;
                saloonModel.longitude = item.longitude;
                saloonModel.lattitude = item.lattitude;
                saloonModels.Add(saloonModel);
            }
            return saloonModels;
        }
        public static List<UserModel> GetTblusers()
        {
            List<UserModel> userModels = new List<UserModel>();
            List<tbluser> user= Users.GetTblusers();
           
            foreach (var item in user)
            {
                UserModel userModel = new UserModel();
                userModel.id = item.id;
                userModel.role = item.tblrole.role;
                userModel.name = item.name;
                userModel.password = item.password;
                userModel.phone = item.phone;
                userModel.Address = item.Address;
                userModel.email = item.email;
                userModel.zipcode = item.zipcode;
                userModel.created_at = item.created_at;
                userModel.updated_at = item.updated_at;
                userModel.role_id = item.role_id;
                userModels.Add(userModel);
            }
            return userModels;
        }
    }
}


