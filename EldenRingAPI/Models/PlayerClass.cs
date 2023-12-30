namespace EldenRingAPI.Models
{

    public enum PlayerStat
    {
        Level,
        Vigor,
        Mind,
        Endurance,
        Strength,
        Dexterity,
        Intelligence,
        Faith,
        Arcane
    }
    public class PlayerClass
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public PlayerStat Stats { get; set; }
    }
}
