using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlogPlatform.Models;
using BlogPlatform.Repositories;
using BlogPlatform.Context;
using System.Linq;

namespace BlogPlatform.tests
{
    public class ContentRepositoryTests : IDisposable
    {
        private BlogPlatformContext db;
        private ContentRepository underTest;

        public ContentRepositoryTests()
        {
            db = new BlogPlatformContext();
            db.Database.BeginTransaction();
            underTest = new ContentRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Create_Increases_Count_of_Contents()
        {
            var startCount = db.Contents.Count();
            underTest.Create(new Content()
            {
                Title = "new blog entry",
                Body = "new blog body",
                Author = "author",
                PublishDate = DateTime.Now,
                GenreId = 1
            });
            var endCount = db.Contents.Count();
            Assert.Equal(startCount + 1, endCount);
        }

    }
}
