using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class Top5
    {
        public Top5(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavDish { get; set; }
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; } = "Coming Soon";


        public static Top5[] GetTop5s()
        {
            //returns an array of type Top5 objects. The objects are declared below.
            Top5 r1 = new Top5(1)
            {
                RestaurantName = "Brick Oven Pizza",
                FavDish = "Pepporoni Pizza",
                Address = "111 E 800 N, Provo, UT 84606",
                Phone = "(801) 374-8800",
                Website = "brickovenrestaurants.com"
            };

            Top5 r2 = new Top5(2)
            {
                RestaurantName = "Don Joaquin Street Tacos",
                Address = "150 W 1230 N St, Provo, UT 84606",
                Phone = "(801) 374-9283",
            };
            Top5 r3 = new Top5(3)
            {
                RestaurantName = "J Dawgs",
                FavDish = "Hot Dawgs",
                Address = "858 700 E, Provo, UT, 84606",
            };
            Top5 r4 = new Top5(4)
            {
                RestaurantName = "Sam Hawk",
                Address = "684 N Freedom Blvd, Provo, UT, 84606",
                Phone = "(801) 377-7766",
                Website = "samhawkprovo.com"
            };
            Top5 r5 = new Top5(5)
            {
                RestaurantName = "DP CHEESESTEAKS",
                FavDish = "Whiz Steak",
                Address = "1774 N University Pkwy, Provo, UT, 84606",
                Phone = "(801) 709-2996",
                Website = "dpcheesesteaks.com"
            };
            return new Top5[] { r1, r2, r3, r4, r5 };
        }
    }
}
