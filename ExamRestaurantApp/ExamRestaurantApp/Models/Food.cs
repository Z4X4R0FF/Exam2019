using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamRestaurantApp.Models
{
    public class Food
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
    }
}
