using API_FARM.Models;
using Microsoft.EntityFrameworkCore;

namespace API_FARM.Seeders
{
    public class AnimalTypeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //pasamos la clase a la cual le vamos a agregar datos
            modelBuilder.Entity<AnimalType>().HasData(
                //creamos datos en base a el modelo 
                new AnimalTypeSeeder{
                    Id: 1,
                    Name: "Anna",
                    Description: "Lorem ipsum dolor sit amet".
                },
                new AnimalTypeSeeder{
                    Id: 2,
                    Name: "John",
                    Description: "Consectetur adipiscing elit."
                },
                new AnimalTypeSeeder{
                    Id: 3,
                    Name: "Michael",
                    Description: "Sed do eiusmod tempor incididunt."
                },
                 new AnimalTypeSeeder{
                    Id: 4,
                    Name: "Juan",
                    Description: "Lorem ipsum dolor sit amet".
                },
                new AnimalTypeSeeder{
                    Id: 5,
                    Name: "Vicente",
                    Description: "Consectetur adipiscing elit."
                },
                new AnimalTypeSeeder{
                    Id: 6,
                    Name: "Monserrat",
                    Description: "Sed do eiusmod tempor incididunt."
                }

            )

        }
    }
}