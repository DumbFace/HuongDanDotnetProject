using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeIdentity.DTOS
{
    public class RegisterDTO
    {
        // [Required]
        public string Email { get; set; }
    }
}