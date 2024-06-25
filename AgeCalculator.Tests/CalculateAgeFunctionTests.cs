using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AgeCalculator.Tests
{
    [TestClass]
    public class CalculateAgeFunctionTests
    {
        [TestMethod]
        public void CalculateAgeFunction_AgeCalculator_WhenDateAfterCurrentDateInputted_ReturnError()
        {
            // Arrange
            string date = DateTime.Now.AddDays(1).ToLongDateString();
            string expected = "Please enter a date before today";
            CalculateAgeFunction calculateAge = new CalculateAgeFunction();


            // Act
            string result = calculateAge.AgeCalculator(date);

            // Assert
            result.Should().BeEquivalentTo(expected);

        }

        [TestMethod]
        public void CalculateAgeFunction_AgeCalculator_WhenDateInvalid_ReturnError()
        {
            // Arrange
            string date = "This is not a date";
            CalculateAgeFunction calculateAge = new CalculateAgeFunction();
            string expected = "Please enter a valid date";


            // Act
            string result = calculateAge.AgeCalculator(date);

            // Assert
            result.Should().BeEquivalentTo(expected);

        }

    }
}
