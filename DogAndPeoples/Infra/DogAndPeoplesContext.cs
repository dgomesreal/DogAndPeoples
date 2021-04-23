using DogAndPeoples.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DogAndPeoples.Infra
{
    public class DogAndPeoplesContext : DbContext
    {
        public DogAndPeoplesContext(DbContextOptions<DogAndPeoplesContext> options) : base(options) { } 
        public DbSet<People> People { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Post> Post { get; set; }

        public DbSet<Tuple<People, Dog>> Tuples { get; set; }
    }
}
