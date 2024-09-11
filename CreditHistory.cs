using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditChecker
{
    public class CreditHistory
    {
        public string type { get; set; }
        public string currency { get; set; }
        public DateTime issuedAt { get; set; }
        public double rate { get; set; }
        public double loanSum { get; set; }
        public int term { get; set; }
        public DateTime repaidAt { get; set; }
        public double currentOverdueDebt { get; set; }
        public int numberOfDaysOnOverdue { get; set; }
        public double remainingDebt { get; set; }
        public string creditId { get; set; }
    }
}
