using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTOCore.Models
{
    //public class ApplicationRole : IdentityRole
    //{
    //    public string Description { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public string IPAddress { get; set; }
    //}
    public class ApplicationRole : IdentityRole<string>

    {

        //public string Description { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public string IPAddress { get; set; }
        public ApplicationRole() : base()
        { }
        public ApplicationRole(string roleName) : base(roleName)
        {
        }

    }
}
