using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_API.DB_Models;
using Test_API.Query;

namespace Test_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            return await _mediator.Send(new ListOfCategory.Query());
        }
        // GET: api/Categories
        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return await _mediator.Send(new SingleCategory.Query {Id=id});
        }

    }
}
