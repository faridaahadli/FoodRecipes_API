using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_API.DB_Models
{
    public class Cuisine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
