using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test_API.DB_Models;

namespace Test_API.Query
{
    public class ListOfCategory
    {
        public class Query : IRequest<List<Category>>
        {

        }
        public class Handler : IRequestHandler<Query, List<Category>>
        {
            protected readonly FoodRecipeDB _context;
            public Handler(FoodRecipeDB context)
            {
                _context = context;
            }
            public async Task<List<Category>> Handle(Query request, CancellationToken cancellationToken)
            {
                var categories = await _context.Categories.ToListAsync();
                return categories;
            }
        }
    }
}
