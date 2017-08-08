using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Controllers;
using TravelBlog.Models;
using Xunit;

namespace TravelBlog.Tests
{
    public class PersonControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            PeopleController controller = new PeopleController();

            IActionResult result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            ViewResult indexView = new PeopleController().Index() as ViewResult;

            object result = indexView.ViewData.Model;

            Assert.IsType<List<Person>>(result);
        }
    }
}