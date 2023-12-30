namespace EldenRingAPI.Models
{
    public class Boss
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public ICollection<string>? Drops { get; set; }
        public string? HealthPoints { get; set; }
    }
}
