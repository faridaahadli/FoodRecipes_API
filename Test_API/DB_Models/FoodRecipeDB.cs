using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_API.DB_Models
{
    public class FoodRecipeDB:DbContext
    {
        public FoodRecipeDB(DbContextOptions options):base(options)
        {           
        }
        public DbSet<Food> Cuisines { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
