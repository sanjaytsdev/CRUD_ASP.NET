
namespace restapi.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Fees { get; set; }
    }
}