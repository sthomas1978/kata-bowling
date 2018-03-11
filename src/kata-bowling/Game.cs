﻿namespace kata.bowling
{
    public class Game
    {
        private int _score = 0;

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }

    }
}
