using EMovies.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Service.Interface
{
    public interface IMovieService
    {
        List<Movie> GetAllProducts();
        Movie GetDetailsForMovie(Guid? id);
        void CreateNewProduct(Movie m);
        void UpdeteExistingProduct(Movie m);
        void DeleteProduct(Guid id);
    }
}
