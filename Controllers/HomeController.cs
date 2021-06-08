using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;    
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();
            var viewModel = new RestaurantViewModel();
            viewModel.Restaurants = model;
            viewModel.MessageOfTheDay = "Hellow from Our Cuisine :)";
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if(model == null)
                return NotFound();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid)
            {
            var newRestaurant = new Restaurant
            {
             Name = model.Name, Cuisine = model.Cuisine
            };

            newRestaurant = _restaurantData.Add(newRestaurant);
            return RedirectToAction(nameof(Details), new {id = newRestaurant.Id});
                
            }
            else
            {
                return View(); 
            }
        }
    }

}