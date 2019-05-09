using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSA_Core2.Models
{
    public class JwtSettings
    {
        public string HmacSecretKey { get; set; }
        public int ExpiryDays { get; set; }
        public string Issuer { get; set; }
        public bool UseRsa { get; set; }
        public string RsaPublicKeyXML { get; set; }
        public string RsaPrivateKeyXML { get; set; }

    }
}
