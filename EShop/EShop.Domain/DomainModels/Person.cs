using EMovies.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Domain.DomainModels
{
    public class Person : BaseEntity
    {
        [Key]
        public string PersonId { get; set; }
        public EMoviesApplicationUser User { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
