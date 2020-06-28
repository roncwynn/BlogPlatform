using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlogPlatform.tests
{
    public class ContentTests
    {
        Content underTest;

        public ContentTests()
        {
            underTest = new Content(1, 1, "Content Title", "Content Body", "Author", DateTime.Now);
        }

        [Fact]
        public void ContentConstructor_Sets_Title_On_ContentModel()
        {
            var result = underTest.Title;

            Assert.Equal("Content Title", result);
        }

        [Fact]
        public void ContentConstructor_Sets_Id_On_ContentModel()
        {
            var result = underTest.ContentId;

            Assert.Equal(1, result);
        }

        [Fact]
        public void ContentConstructor_Sets_BlogBody_On_ContentModel()
        {
            var result = underTest.Body;

            Assert.Equal("Content Body", result);
        }

    }
}
