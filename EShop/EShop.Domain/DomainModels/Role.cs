using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMovies.Domain.DomainModels
{
    public class Role


    {   [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<Person> People { get; set; }


    }
}
