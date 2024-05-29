namespace Hotels.Models
{
    public class Branch
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string? Address { get; set; }

    }
}
