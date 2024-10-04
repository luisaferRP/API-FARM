using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_FARM.Models
{
    [Table("animal_types")]
    public class AnimalType 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
    }
}