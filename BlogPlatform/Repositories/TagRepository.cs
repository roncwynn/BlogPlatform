using BlogPlatform.Context;
using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlogPlatform.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogPlatformContext db;

        public TagRepository(BlogPlatformContext otherDb)
        {
            this.db = otherDb;
        }
        public IEnumerable<Tag> GetAll()
        {
            return db.Tags;
        }

        public Tag GetById(int id)
        {
            return db.Tags.FirstOrDefault(x => x.Id == id);
        }
    }
}
