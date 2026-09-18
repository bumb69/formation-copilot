using Xunit;
using CopilotTraining.Ex1;

namespace CopilotTraining.Tests
{
    public class UserTests
    {
        [Fact]
        public void IsValid_ValidUser_ReturnsTrue()
        {
            var user = new User { FirstName = "John", LastName = "Doe", Age = 30 };
            Assert.True(user.IsValid());
        }

        [Fact]
        public void IsValid_EmptyFirstName_ReturnsFalse()
        {
            var user = new User { FirstName = "   ", LastName = "Doe", Age = 25 };
            Assert.False(user.IsValid());
        }

        [Fact]
        public void IsValid_NullLastName_ReturnsFalse()
        {
            var user = new User { FirstName = "Jane", LastName = null, Age = 20 };
            Assert.False(user.IsValid());
        }

        [Fact]
        public void IsValid_NegativeAge_ReturnsFalse()
        {
            var user = new User { FirstName = "Jane", LastName = "Doe", Age = -1 };
            Assert.False(user.IsValid());
        }
    }
}
