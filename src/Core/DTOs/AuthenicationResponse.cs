using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTOs
{
    public class AuthenticationResponse
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsVerified { get; set; }
        public string JWToken { get; set; }
        //[JsonIgnore]???
        public string RefreshToken { get; set; }
        public string FirebaseToken { get; set; }
        public string Image { get; set; }
        public string ErrorMsg { get; set; }
    }
}
