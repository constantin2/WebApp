using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class RestaurantEditModel
    {
       [Required, MaxLength(30)]
       public string Name{ get; set; } 
        public CuisineType Cuisine { get; set; }
    }
}
