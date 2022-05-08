using EMovies.Domain.DomainModels;
using EMovies.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMovies.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IPersonService _orderService;

        public AdminController(IPersonService orderService)
        {
            _orderService = orderService;
        }

        
    }
}
