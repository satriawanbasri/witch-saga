using WitchSaga.Models;
using WitchSaga.Services;
using WitchSaga.Services.Interface;

namespace WitchSaga.Test
{
    [TestClass]
    public class WitchKillingPatternTests
    {
        private readonly IWitchKillingPattern _witchKillingPattern = new WitchKillingPattern();

        [TestMethod]
        public void NumberOfVillagersKilled_ValidYear_ReturnsCorrectNumber()
        {
            // Arrange & Act
            var resultYear2 = _witchKillingPattern.NumberOfVillagersKilled(2);
            var resultYear4 = _witchKillingPattern.NumberOfVillagersKilled(4);

            // Assert
            Assert.AreEqual(2, resultYear2);
            Assert.AreEqual(7, resultYear4);
        }

        [TestMethod]
        public void NumberOfVillagersKilled_InvalidYear_ReturnsMinusOne()
        {
            // Arrange & Act
            var result = _witchKillingPattern.NumberOfVillagersKilled(-1);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateAverageKilled_ValidData_ReturnsCorrectAverage()
        {
            // Arrange
            var people = new List<Person>
            {
                new Person(10, 12),
                new Person(13, 17)
            };

            // Act
            var result = _witchKillingPattern.CalculateAverageKilled(people);

            // Assert
            Assert.AreEqual(4.5, result);
        }

        [TestMethod]
        public void CalculateAverageKilled_InvalidData_ReturnsMinusOne()
        {
            // Arrange
            var people = new List<Person>
            {
                new Person(-10, 12),
                new Person(13, 17)
            };

            // Act
            var result = _witchKillingPattern.CalculateAverageKilled(people);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateAverageKilled_EmptyList_ReturnsMinusOne()
        {
            // Arrange
            var people = new List<Person>();

            // Act
            var result = _witchKillingPattern.CalculateAverageKilled(people);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
