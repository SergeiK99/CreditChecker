using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditChecker
{
    public class ClientData
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string citizenship { get; set; }
        public Passport passport { get; set; }
        public CreditHistory[] creditHistory { get; set; }
    }
}
