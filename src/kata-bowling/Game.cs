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
            return rolls.ToList().Sum();
        }

    }
}
