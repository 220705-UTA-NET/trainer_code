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
        public void Record_JakeTailsTails_NoReturn()
        {
            // Arrange
            var expected;

            Mock<IRepository> mockRepo = new(); // create the mock repository object

            Game game = new Game(mockRepo); // create the game object

            game.player = "Annie"; // supply a player to the game

            mockRepo.Setup(x => x.CreateNewRound(game.player, 0, 0)).Return();
            // setup the mock repository to accept values and return values as necessary


            // Act


            // Assert
            Assert.Equal(expected: expected, actual: IAsyncResult);
        }


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


            // Act


            // Assert


        }







    }
}
