using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Main
{
    public class ListModel : PageModel
    {
        // private, for injection
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        // use this for both input and output model
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurents { get; set; }

        // constructor
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string searchTerm)
        {
            //Message = "Hello";
            Message = config["Message"];
            Console.WriteLine(HttpContext.Request.QueryString);

            //Restaurents = restaurantData.GetAll();
            Restaurents = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}