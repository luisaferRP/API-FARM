using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_FARM.Models
{
    [Table("animals")]
    public class Animal 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("name")]
        public required string Name { get; set; }

        [MaxLength(250)]
        [Column("description")]
        public string? Description { get; set; }

//Crear conexion para el animaltype por ende crear primero entdades fuertes porque seran necesarias en entidades debiles
        [Required]
        [Column("animal_type_id")]
        public int AnimalTypeId { get; set; }

        
        [Column("weight")]
        public double? Weight { get; set; }

            
        [Column("birth_date")]
        public DateOnly? BirthDate { get; set; }


//crear foreing key para unir el animal tyype con el animal
        [ForeignKey(nameof(AnimalTypeId))]
        public AnimalType? AnimalType { get; set; }
        
    }
}