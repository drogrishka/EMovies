using EMovies.Domain;
using EMovies.Domain.DomainModels;
using EMovies.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Repository.Implementation
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Person> entities;
        string errorMessage = string.Empty;

        public MovieRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Person>();
        }
        public List<Person> getAllPeople()
        {
            return entities
                .Include(z => z.User)
                .Include("ProductInOrders.Product")
                .ToListAsync().Result;
        }
    }
}
