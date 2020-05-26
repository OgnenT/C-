using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public List<Admin> Friends { get; set; }


        public int GetAdminId()
        {
            return ID;
        }
    }
}
