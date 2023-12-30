namespace EldenRingAPI.Models
{
    public class Sorcery
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public double Cost { get; set; }
        public int Slots { get; set; }
        public string? Effects { get; set; }
        public RequiredAttributes? Requires { get; set; }
    }

}
