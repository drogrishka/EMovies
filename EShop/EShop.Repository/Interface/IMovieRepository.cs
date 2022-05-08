using EMovies.Domain;
using EMovies.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Repository.Interface
{
    public interface IMovieRepository
    {
        public List<Person> getAllPeople();

    }
}
