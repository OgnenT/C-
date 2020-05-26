using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
    public static class AdminService
    {
        public static List<Admin> GetAllAdmins()
        {
            return DB.Admins;
        }
        public static Admin GetAdminById(int adminId)
        {
            var admin = DB.Admins.Single(admin => admin.ID == adminId);
            return admin;
        }

        public static List<Admin> GetAllAdminFriends(Admin findAdmin)
        {
            try
            {
                if (findAdmin == null)
                {
                    throw new AdminServiceException("This is a null", new Exception());
                }
                var allAdminFriends = DB.Admins.Single(admin => admin.Equals(findAdmin));
                return allAdminFriends.Friends;
            }
            catch (InvalidOperationException ex)
            {
                throw new AdminServiceException("Dont give me a null", ex);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }
    }
}
