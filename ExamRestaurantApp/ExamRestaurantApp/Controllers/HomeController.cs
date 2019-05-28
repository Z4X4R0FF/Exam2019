using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamRestaurantApp.Models;

namespace ExamRestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        private List<Order> Bin = new List<Order>();
        public HomeController(ApplicationDbContext context)
        {
            db = context;
            if (!db.Users.Any())
            {
                db.Users.Add(new User
                { UserLogin = "Administrator", Password = "AdminHardcorePass" });
                db.SaveChanges();
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult RegisterPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterPage(User user)
        {
            if (db.Users.SingleOrDefault(r => r.UserLogin == user.UserLogin) != null)
                return RedirectToAction("Error", "Home", new { error = "User with same Login was already Created" });
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("MainPage", "Home");
        }

        public IActionResult Error(string error)
        {
            return View((object)error);
        }
        public bool IsLogged()
        {
            return TempData.Peek("CurrentUser") != null;
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            User user;
            try
            {
                user = db.Users
                    .Single(r => r.UserLogin == login && r.Password == password);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", new { error = "Wrong user login or password" });
            }

            TempData["CurrentUser"] = user.Id;
            TempData.Keep("CurrentUser");
            return RedirectToAction("MainPage","Home");
        }

        public IActionResult MainPage()
        {
            User user;
            try
            {
                user = db.Users.Single(r => r.Id == (int)TempData.Peek("CurrentUser"));
            }
            catch (Exception)
            {
                return RedirectToAction("Error", new { error = "You haven't logged in" });
            }
            return View(user);
        }
        public IActionResult Exit()
        {
            if (!IsLogged()) return RedirectToAction("Error", new { error = "You haven't logged in" });
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
        #region AdminControls
        [HttpPost]
        public IActionResult AddRestaurant(string name)
        {
            Restaurant rest = new Restaurant { Name = name };
            rest.Foods = new List<Food>();
            db.Restaurants.Add(rest);
            db.SaveChanges();
            return RedirectToAction("MainPage","Home");
        }
        [HttpPost]
        public IActionResult AddFoodToRestaurant(int restaurantId,string name,int cost,string description)
        {
            Food food = new Food { Name = name, Cost = cost, Description = description,RestaurantId=restaurantId };
            db.Foods.Add(food);
            db.SaveChanges();
            return RedirectToAction("MainPage","Home");
        }
        #endregion
        #region UserControls
        public IActionResult BrowseRestaurants()
        {
            return View(db.Restaurants.ToList());
        }
        public IActionResult ViewRestaurant(int id)
        {
            var foods = db.Foods.Where(r => r.RestaurantId == id);
            var rest = db.Restaurants.Single(r => r.Id == id);
            rest.Foods = foods.ToList();
            return View(rest);
        }
        public IActionResult AddToBin(int id)
        {
            var order = new Order {FoodId=id,UserId=(int)TempData.Peek("CurrentUser") };
            Bin.Add(order);
            return RedirectToAction("MakeOrder", "Home");
        }
        public IActionResult SeeBin()
        {
            return View(Bin);
        }

        public IActionResult RemoveFromBin(int id)
        {
            var order = Bin.Single(r => r.Id == id);
            Bin.Remove(order);
            return RedirectToAction("SeeBin", "Home");
        }
        public IActionResult MakeOrder()
        {
            foreach(var order in Bin)
            {
                db.Orders.Add(order);
            }
            db.SaveChanges();
            Bin.Clear();
            return RedirectToAction("SeeBin", "Home");
        }
        #endregion
    }
}
