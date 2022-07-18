using Xunit;
using Xunit.Sdk;
using System;
using CoinFlipper.Logic;

namespace CoinFlipper.Tests
{

    // common to have one test class per logical/programatic class
    public class RoundTest
    {

        // typical naming covention of test methods:
        // UnitOfTest_TestConditon_DesiredBehavior

        [Fact]
        public void PlayRound_Heads_Win()
        {
            // unit tests are supposd to be laser focused on one behavior of one small unit of code.
            // to help us do that, we divide the tests into three logical steps: Arrange, Act, Assert

            // Arrange : what setup needs to take place for the code to model the desired behavior?
            var round = new Round(0);

            // Act : the behavior under testing
            var result = round.PlayRound(0);

            // Assert : verify that the behavior was as expected
            var expected = "Player chose: Heads\r\nFlip result: Heads\r\nRound result: You win!\r\n";
            Assert.Equal(expected: expected, actual: result);
        }

        [Fact]
        public void PlayRound_Tails_Loose()
        {
            // Arrange : what setup needs to take place for the code to model the desired behavior?
            var round = new Round(0);

            // Act : the behavior under testing
            var result = round.PlayRound(1);

            // Assert : verify that the behavior was as expected
            var expected = "Player chose: Tails\r\nFlip result: Heads\r\nRound result: You lose!\r\n";
            Assert.Equal(expected: expected, actual: result);
        }
    }
}