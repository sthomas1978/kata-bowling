using kata.bowling;
using System;
using System.Linq;
using Xunit;

namespace kata_bowling.tests
{
    public class GameTests
    {
        [Fact]
        public void Score_GutterGame_ReturnsZero()
        {
            var game = new Game();

            Enumerable.Range(0, 20)
                .ToList()
                .ForEach(roll =>
                {
                    game.Roll(0);
                });

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void Score_RollAllOnes_Returns20()
        {
            var game = new Game();

            Enumerable.Range(0, 20)
                .ToList()
                .ForEach(roll =>
                {
                    game.Roll(1);
                });

            Assert.Equal(20, game.Score());
        }

    }
}
