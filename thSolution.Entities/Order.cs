using System;
using System.Collections.Generic;
using thSolution.Enums;

namespace thSolution.Entities
{
    public class Order : CommonEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public Contact Contact { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Users Users { get; set; }
    }
}
