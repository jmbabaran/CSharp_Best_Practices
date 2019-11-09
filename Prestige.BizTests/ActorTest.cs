using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currenctActor = new Actor();
            var expected = "Actor";


            // Act
            var result = currenctActor.GetOccupation();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            // Arrange
            var currenctActor = new Actor("Johnny Boy");
            var expected = "Johnny Boy";


            // Act
            var result = currenctActor.ActorName;

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSettingObjectProperty()
        {
            // Arrange
            var currenctActor = new Actor();
            currenctActor.ActorName = "Johnny Boy";
            var expected = "Johnny Boy";


            // Act
            var result = currenctActor.ActorName;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookingWithoutDate()
        {
            // Arrange
            var details = "Book can change if " +
            "actor starts trouble.";
            var currenctActor = new Actor("Johnny Boy");
            var expected = "Actor Johnny Boy is booked. " + details;


            // Act
            var result = currenctActor.BookActor();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookingWithDate()
        {
            // Arrange
            var details = "Book can change if " +
            "actor starts trouble.";
            var currenctActor = new Actor("Johnny Boy");
            var theDate = "Sept 21, 2019";
            var expected = "Actor Johnny Boy is booked on " + theDate + ". " + details;


            // Act
            var result = currenctActor.BookActor(theDate);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFormattingOnBookingActor()
        {
            // Arrange
            var details = "Book can change if " +
            "actor starts trouble.";
            var currenctActor = new Actor("Johnny Boy     ");
            var expected = "Actor Johnny Boy is booked. " + details;


            // Act
            var result = currenctActor.BookActor();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            // Arrange
            var currenctActor = new Actor{  ActorName="Jen"};
            var expected = "Regular Actor.";


            // Act
            var result = currenctActor.ActorDescription;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorAge()
        {
            // Arrange
            var currenctActor = new Actor { ActorName = "Jen", ActorAge=46 };
            var expected = 46;


            // Act
            var result = currenctActor.ActorAge;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetAgencyName()
        {
            // Arrange
            var currenctActor = new Actor { ActorName = "Jen", ActorAge = 46 };
            var expected = "Prestige Talent";


            // Act
            var result = currenctActor.GetAgency();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
