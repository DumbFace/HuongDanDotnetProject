using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeIdentity.Models
{
    public class RoleViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; } = false;
    }
}