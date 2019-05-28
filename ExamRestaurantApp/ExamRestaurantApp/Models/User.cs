using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamRestaurantApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
