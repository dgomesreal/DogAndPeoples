using DogAndPeoples.Models;
using Microsoft.EntityFrameworkCore;

namespace DogAndPeoples.Infra
{
    public class DogAndPeoplesContext : DbContext
    {
        public DogAndPeoplesContext(DbContextOptions<DogAndPeoplesContext> options) : base(options) { } 
        public DbSet<People> Peoples { get; set; }
        public DbSet<Dog> Dogs { get; set; }

    }
}
