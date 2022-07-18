using CoinFlipper.Data;
using CoinFlipper.App;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper.Tests
{
    public class GameTest
    {
        [Fact]
        public void GetRecords_Annie_CorrecetOutput()
        {
            // Test Driven Design is the use of unit testing to help us write consice and topical code
            // start by writing a unit test that your method/functionality FAILS.
            // Then, write out the methods so that your test JUST passes.
            // Then update your testing so that your methods fail the newly updated test.
            // Update your methods until your tests pass again.
            // Rinse and Repeat

            // Arrange
            Mock<IRepository> mockRepo = new();
            // Mock allows us to fake a database in unit testing (among other things)
            mockRepo.Setup(x => x.GetPlayerRecords("Jimmy")).Returns("7/18/2022 4:06:53 AM +00:00KadinTailsTails");
            // use .Setup to establish a behavior. when the metod gets x, it returns y

            var game = new Game(mockRepo.Object);
            game.player = "Jimmy";

            // Act
            var result = game.GetRecords();

            // Assert
            string expected = "Displaying Player Records for Jimmy: 7/18/2022 4:06:53 AM +00:00KadinTailsTails\r\n";

            Assert.Equal(expected, result);
        }







    }
}
