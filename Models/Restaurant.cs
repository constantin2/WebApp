using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Restaurant 
    {
       public int Id { get; set; }
       [Display(Name="Restaurant Name")]
       [Required, MaxLength(30)]
       public string Name { get; set; }
       public CuisineType Cuisine { get; set; }
    }

}