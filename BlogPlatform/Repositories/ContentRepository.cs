using BlogPlatform.Context;
using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class ContentRepository : IRepository<Content>
    {
        private BlogPlatformContext db;
        public ContentRepository(BlogPlatformContext otherDB)
        {

            this.db = otherDB;

        }

        public IEnumerable<Content> GetAll()
        {
            return db.Contents;
        }

        public Content GetById(int id)
        {
            return db.Contents.FirstOrDefault(x => x.ContentId == id);
        }
    }
}
