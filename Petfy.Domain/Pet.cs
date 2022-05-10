namespace Petfy.Domain
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? PetNumber { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Type { get; set; }
    }
}