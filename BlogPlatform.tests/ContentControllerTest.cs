using BlogPlatform.Controllers;
using BlogPlatform.Models;
using BlogPlatform.Repositories;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NSubstitute;

namespace BlogPlatform.tests
{
    public class ContentControllerTest
    {

        ContentController underTest;
        IRepository<Content> contentRepo;

        public ContentControllerTest()
        {
            contentRepo = Substitute.For<IRepository<Content>>();
            underTest = new ContentController(contentRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            // Arrange
            var expectedContent = new List<Content>();
            contentRepo.GetAll().Returns(expectedContent);

            var result = underTest.Index();

            Assert.Equal(expectedContent, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Content_To_View()
        {
            // Arrange with Mocking and NSubstitute
            var expectedContent = new Content();
            contentRepo.GetById(1).Returns(expectedContent);

            var result = underTest.Details(1);

            Assert.Equal(expectedContent, result.Model);
        }

    }
}

