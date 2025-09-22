namespace HangMan
{
    internal class Game
    {
        private WordProvider _Word;
        private Player _Player;
        private char[] CurrentWord;

        public Game(WordProvider word, Player player)
        {
            _Word = word;
            _Player = player;
            CurrentWord = word.ChoosedWord.ToCharArray();
        }

        public void StartGame()
        {
            InicializedBoard();
            while (_Player.IsAlive())
            {
                Console.Write("Enter a letter: ");
                char c = char.Parse(Console.ReadLine());

                if (!char.IsLetter(c))
                    throw new FormatException();

                if (_Player.GuessedLetters.Contains(c))
                {
                    Console.WriteLine("You already entered this letter, try again!");
                    continue;
                }
                _Player.GuessedLetters.Add(c);
                if (!_Word.ChoosedWord.Contains(c))
                {
                    _Player.LossLife();
                }else if (_Word.ChoosedWord.Contains(c))
                {
                    UpdateBoard(c);
                }
                if (!CurrentWord.Contains('_'))
                {
                    Console.WriteLine("You Won, Nice Job!!!!!!");
                    return;
                }
                    
            }
        }

        public void InicializedBoard()
        {
            for(int i = 0; i < CurrentWord.Length; i++)
            {
                CurrentWord[i] = '_';
                Console.Write(CurrentWord[i] + " ");
            }
            Console.WriteLine();
        }

        public void UpdateBoard(char c)
        {
            for (int i = 0;i < CurrentWord.Length;i++)
            {
                if (_Word.ChoosedWord[i] == c)
                {
                    CurrentWord[i] = c;
                }
                Console.Write(CurrentWord[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
