using EMovies.Domain;
using EMovies.Domain.DomainModels;
using EMovies.Repository.Interface;
using EMovies.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Service.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IMovieRepository _movieRepository;

        public PersonService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<Person> getAllPeople()
        {
            return this._movieRepository.getAllPeople();
        }

       
    }
}
