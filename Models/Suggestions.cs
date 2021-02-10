using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class Suggestions
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; }

        [Required(ErrorMessage = "Phone Number is needed.")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(([0-9]{3})\)-([0-9]{3})-([0-9]{4})$", ErrorMessage = "The Phone Number must match the follwoing format (801)-123-4567")] //use regular expression. Phone must be entered a certain way.
        public string Phone { get; set; }
    }
}
