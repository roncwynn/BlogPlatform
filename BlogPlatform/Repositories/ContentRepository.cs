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

        public void Create(Content content)
        {
            db.Contents.Add(content);
            db.SaveChanges();
        }

        public void Delete(Content content)
        {
            db.Contents.Remove(content);
            db.SaveChanges();
        }

        public IEnumerable<Content> GetAll()
        {
            return db.Contents;
        }

        public Content GetById(int id)
        {
            return db.Contents.FirstOrDefault(x => x.ContentId == id);
        }

        public void Update(Content content)
        {
            //var entity = await DbContextInMemory.FindAsync(content);
            db.Contents.Update(content);
            db.SaveChanges();
        }
    }
}
