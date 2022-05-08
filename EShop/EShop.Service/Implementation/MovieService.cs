using EMovies.Domain.DomainModels;
using EMovies.Domain.DTO;
using EMovies.Domain.Relations;
using EMovies.Repository.Interface;
using EMovies.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMovies.Service.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IUserRepository _userRepository;

        public ProductService(IRepository<Movie> movieRepository,IUserRepository userRepository)
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
 
        }


      

        public void CreateNewMovie(Movie m)
        {
            this._movieRepository.Insert(m);
        }

        public void DeleteMovie(Guid id)
        {
            var movie = this.GetDetailsForMovie(id);
            this._movieRepository.Delete(movie);
        }

        public List<Movie> GetAllProducts()
        {
            return this._movieRepository.GetAll().ToList();
        }

        public Movie GetDetailsForMovie(Guid? id)
        {
            return this._movieRepository.Get(id);
        }


        public void UpdeteExistingMovie(Movie m)
        {
            this._movieRepository.Update(p);
        }
    }
}
