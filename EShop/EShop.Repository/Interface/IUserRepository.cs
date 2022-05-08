using EMovies.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<EMoviesApplicationUser> GetAll();
        EMoviesApplicationUser Get(string id);
        void Insert(EMoviesApplicationUser entity);
        void Update(EMoviesApplicationUser entity);
        void Delete(EMoviesApplicationUser entity);
    }
}
