using DevOpsDemo.Controllers;
using DevOpsDemo.Models;
using DevOpsDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace DevOpsDemo.Tests
{
    public class PostTestController
    {
        private readonly PostRepository repository;

        public PostTestController()
        {
            repository = new PostRepository();
        }

        [Fact]
        public void Test_Index_View_Result()
        {
            // Arrange
            var controller = new HomeController(repository);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Test_Index_Return_Result()
        {
            // Arrange
            var controller = new HomeController(repository);

            // Act
            var result = controller.Index();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_Index_GetPosts_Match_Data()
        {
            // Arrange
            var controller = new HomeController(repository);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(4, model.Count);
            Assert.Equal(101, model[0].PostId);
            Assert.Equal("DevOps Demo Title 1", model[0].Title);
        }
    }
}
