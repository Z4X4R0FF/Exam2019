using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamRestaurantApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
