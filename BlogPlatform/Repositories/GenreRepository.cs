using BlogPlatform.Context;
using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        //public List<RestaurantReview.Models.Restaurant> restaurants;

        private BlogPlatformContext db;

        public GenreRepository(BlogPlatformContext otherDb)
        {
            this.db = otherDb;
        }
        public IEnumerable<Genre> GetAll()
        {
            return db.Genres;
        }

        public Genre GetById(int id)
        {
            return db.Genres.FirstOrDefault(x => x.Id == id);
        }
    }
}
