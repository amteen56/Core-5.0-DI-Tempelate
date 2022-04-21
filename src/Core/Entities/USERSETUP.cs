using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities
{
    [Table("USERSETUP")]
    public class USERSETUP
    {
        [MaxLength(15)]
        public string USER_ID { get; set; }
        [MaxLength(30)]
        public string USER_NAME { get; set; }
        [MaxLength(64)]
        public string USER_PASSWORD { get; set; }
        [MaxLength(50)]
        public string EMAIL { get; set; }

        [MaxLength(100)]
        public string PROFILE_IMAGE { get; set; }
        [MaxLength(1)]
        public string USER_ACTIVE { get; set; }
        public string CONTACT_NO { get; set; }

        [Column(TypeName = "numeric")]
        public int? PWD_EXPIRY_DAYS { get; set; }
        [MaxLength(30)]
        public string USER_EMAIL { get; set; }
        [MaxLength(15)]
        public string USER_MSISDN { get; set; }
        [Column(TypeName = "numeric")]
        public int? USER_LOGIN_ATTEMPT { get; set; }
        public DateTime? USER_LOCK_DATETIME { get; set; }
        public string OTP { get; set; }
        public DateTime? OTP_EXPIRY { get; set; }
        public int? OTP_STATUS { get; set; }
        public string USER_TYPE { get; set; }
        public string FIREBASE_TOKEN { get; set; }
        public string TOKEN { get; set; }
        public DateTime? TOKEN_CREATED_ON { get; set; }
        public DateTime? TOKEN_EXPIRY { get; set; }
        public DateTime? TOKEN_REVOKED_ON { get; set; }
    }
}
