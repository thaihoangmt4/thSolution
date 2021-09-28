using System;

namespace thSolution.Entities
{
    public class SystemActivity : CommonEntity
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public string ActionDate { get; set; }
        public string FunctionId { get; set; }
        public Guid UserId { get; set; }
        public string ClientIp { get; set; }
    }
}
