namespace HangMan
{
    internal class WordProvider
    {
        private List<string> _WordList = new List<string>();
        public string ChoosedWord { get; set; }
        private Random _Random = new Random();

        public WordProvider(string path)
        {
            FileReader(path);
            ChoosedWord = _WordList[_Random.Next(_WordList.Count)].ToLower();         
        }

        public void FileReader(string path)
        {
            var lines = File.ReadAllLines(path);
            foreach(var line in lines)
            {
                string[] words = line.Split(' ');
                foreach(var word in words)
                {
                    _WordList.Add(word);
                }
            }
        }
    }
}
