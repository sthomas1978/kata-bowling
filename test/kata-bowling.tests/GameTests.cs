using kata.bowling;
using System;
using System.Linq;
using Xunit;

namespace kata_bowling.tests
{
    public class GameTests
    {
        private readonly Game _game;

        public GameTests()
        {
            _game = new Game();
        }

        private void RollMany(int rolls, int pins)
        {
            Enumerable.Range(0, rolls)
                .ToList()
                .ForEach(roll =>
                {
                    _game.Roll(pins);
                });
        }

        [Fact]
        public void Score_GutterGame_ReturnsZero()
        {
            RollMany(20, 0);
            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void Score_RollAllOnes_Returns20()
        {
            RollMany(20, 1);
            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void Score_RollsASpare_ReturnsCorrectScore()
        {
            _game.Roll(5);
            _game.Roll(5); // we have spare here;
            _game.Roll(3);

            RollMany(17, 0);

            Assert.Equal(16, _game.Score());
        }
    }
}
