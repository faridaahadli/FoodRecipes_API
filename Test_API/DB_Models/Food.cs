using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_API.DB_Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Preparation { get; set; }
        public string Tools { get; set; }
        public string Ingredients { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
      
    }

}
