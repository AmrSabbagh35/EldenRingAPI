using System.ComponentModel.DataAnnotations;

namespace EldenRingAPI.Models
{
    public class Weapon
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

    public class AttackDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
    }

    public class DefenceDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
    }

    public class RequiredAttributes
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
    }

    public class ScalingDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Scaling { get; set; }
    }
}
