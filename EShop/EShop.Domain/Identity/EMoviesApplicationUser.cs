using EMovies.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace EMovies.Domain.Identity
{
    public class EMoviesApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
