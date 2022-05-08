using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovies.Domain.DomainModels
{
    public class Movie : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieImage { get; set; }
        [Required]
        public string MovieDescription { get; set; }
      
        [Required]
        public double MovieRating { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Person> People { get; set; }

    }
}
