using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test_API.DB_Models;

namespace Test_API.Query
{
    public class SingleCategory
    {
        public class Query: IRequest<Category>
        {
            public int Id { get; set; }
        }
        public class Handler : IRequestHandler<Query,Category>
        {
            private readonly FoodRecipeDB _context;
            public Handler(FoodRecipeDB context)
            {
                _context = context;
            }

            public async Task<Category> Handle(Query request, CancellationToken cancellationToken)
            {
                var category = await _context.Categories.FindAsync(request.Id);
                return category;
            }
        }
    }
}
