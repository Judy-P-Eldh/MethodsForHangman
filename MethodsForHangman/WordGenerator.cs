namespace MethodsForHangman
{
    internal class WordGenerator
    {
        private readonly List<string> wordToFind;
        public WordGenerator() => wordToFind = new List<string>
        {
                "härligt",
                "katastrofteam",
                "fjärrtåg",
                "specialerbjudande",
                "krigsveteran",
                "armborst",
                "hej",
                "blomkruka",
                "flintskallig",
                "hjärtstartare",
                "nyhetsuppläsare",
                "halvfabrikat"
        };

        public string GenerateWord()
        {
            Random random = new();
            int word = random.Next(wordToFind.Count);
            //Console.WriteLine(wordToFind[word]);  //Visar det för att se att det funkar.
            return wordToFind[word];
        }
    }
}
