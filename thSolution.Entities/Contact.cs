namespace thSolution.Entities
{
    public class Contact : CommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
