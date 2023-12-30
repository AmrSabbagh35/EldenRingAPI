using System.ComponentModel.DataAnnotations;

namespace EldenRingAPI.Models
{
    public class Armor
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public double Weight { get; set; }
        public DamageNegationDetails? DmgNegation { get; set; }
        public ResistanceDetails? Resistance { get; set; }
    }

    public class DamageNegationDetails
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
    }

    public class ResistanceDetails
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
    }
}
