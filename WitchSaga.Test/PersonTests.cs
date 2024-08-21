using WitchSaga.Models;

namespace WitchSaga.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void CalculateYearOfBirth_ValidData_ReturnsCorrectYear()
        {
            // Arrange
            var person = new Person(10, 12);

            // Act
            var result = person.CalculateYearOfBirth();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculateYearOfBirth_InvalidData_ReturnsMinusOne()
        {
            // Arrange
            var person = new Person(-5, 5);

            // Act
            var result = person.CalculateYearOfBirth();

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
