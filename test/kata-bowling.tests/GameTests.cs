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
            RollSpare();
            _game.Roll(3);

            RollMany(17, 0);

            Assert.Equal(16, _game.Score());
        }

        [Fact]
        public void Score_RollAStrike_ReturnsCorrectScore()
        {
            _game.Roll(10); //strike
            _game.Roll(3);
            _game.Roll(4);

            RollMany(16, 0);

            Assert.Equal(24, _game.Score());
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5); // we have spare here;
        }
    }
}
