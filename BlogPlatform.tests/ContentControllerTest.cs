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
        public void Index_Passes_All_Content_To_View()
        {
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
            var expectedContent = new Content();
            contentRepo.GetById(1).Returns(expectedContent);

            var result = underTest.Details(1);
            Assert.Equal(expectedContent, result.Model);
        }

        [Fact]
        public void Create_Returns_a_ViewResult()
        {
            var result = underTest.Create();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Post_Returns_ActionResult()
        {
            var result = underTest.Create(new Content());

            Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Create_Will_Not_Execute_if_Invalid_ModelState()
        {
            underTest.ModelState.AddModelError("Title", "Title is required");
            var newContent = new Content();

            underTest.Create(newContent);
            contentRepo.DidNotReceive().Create(newContent);
        }

        [Fact]
        public void Create_Will_Add_Content_if_Valid_ModelState()
        {
            var newContent = new Content();
            underTest.Create(newContent);
            contentRepo.Received().Create(newContent);
        }

    }
}

