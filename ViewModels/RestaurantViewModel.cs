using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class RestaurantViewModel
    {
        public IEnumerable<Restaurant> Restaurants {get; set;}
        public string MessageOfTheDay { get; set; }  
    }
}
