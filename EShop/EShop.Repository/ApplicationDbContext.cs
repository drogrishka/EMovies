using EMovies.Domain.DomainModels;
using EMovies.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EMovies.Repository
{
    public class ApplicationDbContext : IdentityDbContext<EMoviesApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Products { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Movie>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Genre>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Person>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Role>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
