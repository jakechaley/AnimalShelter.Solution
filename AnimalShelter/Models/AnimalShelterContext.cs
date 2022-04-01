using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Sophie", Species = "Dog", Age = 13, Gender = "Female", Breed = "Celtic Setter"},
                new Animal { AnimalId = 2, Name = "Bucket", Species = "Dog", Age = 4, Gender = "Male", Breed = "English Bulldog"},
                new Animal { AnimalId = 3, Name = "Lawrence", Species = "Dog", Age = 5, Gender = "Male", Breed = "Coon Hound"},
                new Animal { AnimalId = 4, Name = "Gary2", Species = "Dog", Age = 6, Gender = "Male", Breed = "Jack Russel Terrier"},
                new Animal { AnimalId = 5, Name = "Penny", Species = "Dog", Age = 7, Gender = "Female", Breed = "Pitbull"},
                new Animal { AnimalId = 6, Name = "Zane", Species = "Dog", Age = 1, Gender = "Male", Breed = "Golden Retriever"},
                new Animal { AnimalId = 7, Name = "Marcus", Species = "Dog", Age = 4, Gender = "Male", Breed = "Poodle"},
                new Animal { AnimalId = 8, Name = "Zoie", Species = "Dog", Age = 3, Gender = "Female", Breed = "Bull Terrier"},
                new Animal { AnimalId = 9, Name = "Spot", Species = "Dog", Age = 6, Gender = "Female", Breed = "Dalmation"},
                new Animal { AnimalId = 10, Name = "Lucky", Species = "Dog", Age = 5, Gender = "Female", Breed = "Beagle"},
                new Animal { AnimalId = 11, Name = "Charlie", Species = "Cat", Age = 12, Gender = "Female", Breed = "Orange Tabby"},
                new Animal { AnimalId = 12, Name = "Dog", Species = "Cat", Age = 4, Gender = "Male", Breed = "Maine Coon"},
                new Animal { AnimalId = 13, Name = "Beans", Species = "Cat", Age = 5, Gender = "Male", Breed = "Scottish Fold"},
                new Animal { AnimalId = 14, Name = "Dave", Species = "Cat", Age = 6, Gender = "Male", Breed = "Russian Blue"},
                new Animal { AnimalId = 15, Name = "Oona", Species = "Cat", Age = 7, Gender = "Female", Breed = "Tabby"},
                new Animal { AnimalId = 16, Name = "Oliver", Species = "Cat", Age = 1, Gender = "Male", Breed = "Bengal"},
                new Animal { AnimalId = 17, Name = "Zero", Species = "Cat", Age = 4, Gender = "Male", Breed = "Siamese"},
                new Animal { AnimalId = 18, Name = "LeeLoo", Species = "Cat", Age = 3, Gender = "Female", Breed = "Sphynx"},
                new Animal { AnimalId = 19, Name = "Madame Princess Cat", Species = "Cat", Age = 6, Gender = "Female", Breed = "Oriental Shorthair"},
                new Animal { AnimalId = 20, Name = "Boo", Species = "Cat", Age = 5, Gender = "Female", Breed = "Persian"}
                );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}