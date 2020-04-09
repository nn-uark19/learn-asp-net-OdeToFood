using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurant> restaurents;
        public InMemoryRestaurantData()
        {
            restaurents = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Location = "Marryland", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine=CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurents
                   orderby r.Name
                   select r;

        }
    }
}
