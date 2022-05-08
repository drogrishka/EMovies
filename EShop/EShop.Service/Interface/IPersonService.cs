using EMovies.Domain;
using EMovies.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMovies.Service.Interface
{
    public interface IPersonService
    {
        public List<Person> getAllPeople();
       
    }
}
