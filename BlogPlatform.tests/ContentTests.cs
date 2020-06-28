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
            DateTime date = Convert.ToDateTime("2020-06-28T12: 55:35.0000000-4:00");
            underTest = new Content(1, 1, "Content Title", "Content Body", "Author", date);
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

        [Fact]
        public void ContentConstructor_Sets_Author_On_ContentModel()
        {
            var result = underTest.Author;

            Assert.Equal("Author", result);
        }

        [Fact]
        public void ContentConstructor_Sets_PublishDate_On_ContentModel()
        {
            var result = underTest.PublishDate;
            DateTime date = Convert.ToDateTime("2020-06-28T12: 55:35.0000000-4:00");
            Assert.Equal(date, result);
        }

    }
}
