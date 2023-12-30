namespace EldenRingAPI.Models
{
    public class Shield
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public double Weight { get; set; }
        public AttackDetails? Attack { get; set; }
        public DefenceDetails? Defence { get; set; }
        public RequiredAttributes? RequiredAttributes { get; set; }
        public ScalingDetails? ScalesWith { get; set; }
    }

}
