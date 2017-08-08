using TravelBlog.Models;
using Xunit;

namespace TravelBlog.Tests
{
    public class PersonTests
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var person = new Person();

            //Act
            var result = person.Name;

            //Assert
            Assert.Equal("Joshua", result);
        }
    }
}
