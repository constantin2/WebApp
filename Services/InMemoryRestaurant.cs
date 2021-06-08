using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurant()
        {
             _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Scott`s Pizza PLace"},
                new Restaurant { Id = 2, Name = "Tersiguels"},
                new Restaurant { Id = 3, Name = "Indians Gifts"}          
            };
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(r => r.Id) +1;
            _restaurants.Add(newRestaurant);

            return newRestaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public  IEnumerable<Restaurant> GetAll() => _restaurants.OrderBy(r => r.Name);
    }
}
