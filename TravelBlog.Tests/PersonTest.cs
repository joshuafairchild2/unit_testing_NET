using TravelBlog.Models;
using Xunit;

namespace TravelBlog.Tests
{
    public class PersonTests
    {
        [Fact]
        public void GetNameTest()
        {
            Person person = new Person();
            person.Name = "Joshua";

            string result = person.Name;

            Assert.Equal("Joshua", result);
        }
    }
}
