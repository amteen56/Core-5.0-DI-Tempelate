using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.DTOs
{
    public class AuthenicationParam
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Password { get; set; }
        public string DeviceID { get; set; }
    }
}
