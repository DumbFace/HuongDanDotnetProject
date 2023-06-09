using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeIdentity.Models;

namespace Domain.Users
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }

}