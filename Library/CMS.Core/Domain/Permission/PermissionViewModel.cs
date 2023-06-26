using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Roles
{
    public class PermissionViewModel
    {
        public string GroupPermission { get; set; }
        public IList<RoleClaimsViewModel> RoleClaims { get; set; }
    }

    public class RoleClaimsViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; } = false;
    }
}