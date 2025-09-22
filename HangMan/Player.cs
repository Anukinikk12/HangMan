namespace HangMan
{
    internal class Player
    {
        public int Lives { get; private set; } = 6;
        public List<char> GuessedLetters { get; set; }

        public Player()
        {
            GuessedLetters = new List<char>();
        }

        public void LossLife()
        {
            Lives--;
            if (IsAlive())
            {
                string result = Lives switch
                {
                    5 => "Head",
                    4 => "Body",
                    3 => "Left Hand",
                    2 => "Right Hand",
                    1 => "Left Leg"
                };
                Console.WriteLine($"Ops {result} on hanger");
            }
            else
            {
                Console.WriteLine("Game over, you looser!");
            }

        }

        public bool IsAlive()
        {
            return Lives > 0;
        }

    }
}
