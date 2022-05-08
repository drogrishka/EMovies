using EMovies.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Domain.DomainModels
{
    public class Genre : BaseEntity
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }
        
        public virtual ICollection<Movie> Movies { get; set; }



    }
}
