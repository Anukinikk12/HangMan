namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game(new WordProvider(@"C:\Users\Anuki\Desktop\everything\smth\words.txt"), new Player());
                game.StartGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Input must be letter!");
            }
            
        }
    }
}
