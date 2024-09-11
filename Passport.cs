using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditChecker
{
    public class Passport
    {
        public string series { get; set; }
        public string number { get; set; }
        public string issuer { get; set; }
        public string issuerCode { get; set; }
        public DateTime issuedAt { get; set; }
    }
}
