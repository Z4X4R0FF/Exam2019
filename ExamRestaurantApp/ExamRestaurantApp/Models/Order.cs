using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamRestaurantApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
