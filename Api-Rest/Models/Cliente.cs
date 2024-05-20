namespace Api_Rest.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Lastname { get; set; }
        public required int Age { get; set; }
    }
}
