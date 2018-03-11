using System.Linq;

namespace kata.bowling
{
    public class Game
    {
        private int currentRoll = 0;
        private int[] rolls = new int[21];

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[i] + rolls[i + 1] == 10)
                {
                    score = 10 + rolls[i + 2];
                } else {
                    score += rolls[i] + rolls[i + 1];
                }

                i += 2;
            }

            return score;
        }

    }
}
