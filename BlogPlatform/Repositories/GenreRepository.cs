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

        public void Delete(Content content)
        {
            throw new NotImplementedException();
        }
        public void Create(Content content)
        {
            throw new NotImplementedException();
        }
        public void Update(Content content)
        {
            throw new NotImplementedException();
        }

        public void Create(Genre obj)
        {
            throw new NotImplementedException();
        }

    }
}
