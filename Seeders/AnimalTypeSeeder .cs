using API_FARM.Models;
using Microsoft.EntityFrameworkCore;

namespace API_FARM.Seeders
{
    public class AnimalTypeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Pasamos la clase a la cual le vamos a agregar datos
            modelBuilder.Entity<AnimalType>().HasData(
                // Creamos datos en base al modelo
                new AnimalType
                {
                    Id = 1,
                    Name = "Anna",
                    Description = "Lorem ipsum dolor sit amet"
                },
                new AnimalType
                {
                    Id = 2,
                    Name = "John",
                    Description = "Consectetur adipiscing elit."
                },
                new AnimalType
                {
                    Id = 3,
                    Name = "Michael",
                    Description = "Sed do eiusmod tempor incididunt."
                },
                new AnimalType
                {
                    Id = 4,
                    Name = "Juan",
                    Description = "Lorem ipsum dolor sit amet"
                },
                new AnimalType
                {
                    Id = 5,
                    Name = "Vicente",
                    Description = "Consectetur adipiscing elit."
                },
                new AnimalType
                {
                    Id = 6,
                    Name = "Monserrat",
                    Description = "Sed do eiusmod tempor incididunt."
                }
            );
        }
    }
}
