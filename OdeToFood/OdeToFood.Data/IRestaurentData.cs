using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurentData : IRestaurentData
    {
        public List<Restaurant> restaurents;
        public InMemoryRestaurentData()
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
