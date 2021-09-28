using System;
using thSolution.Enums;

namespace thSolution.Entities
{
    public class Tracsaction : CommonEntity
    {
        public int Id { get; set; }
        public DateTime TracsactionDate { get; set; }
        public int ExternalTracsactionId { get; set; }
        public int Amount { get; set; }
        public Decimal Fee { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
        public TracsactionStatus Status { get; set; }
        public string Provider { get; set; }
    }
}
