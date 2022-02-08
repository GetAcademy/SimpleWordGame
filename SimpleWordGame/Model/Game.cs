using System;

namespace SimpleWordGame.Model
{
    public class Game
    {
        private readonly string _word;

        public Guid Id { get; }
        public int WordLength => _word.Length;

        public string Word { get; private set; }

        public Game(string word)
        {
            _word = word;
            Id = Guid.NewGuid();
            Word = string.Empty.PadLeft(WordLength, 'X');
        }

        public void Guess(string letterStr)
        {
            char letter = char.ToLower(letterStr[0]);
            for (int i = 0; i < WordLength; i++)
            {
                if(char.ToLower(_word[i]) == letter)
                {
                    var word = Word.ToCharArray();
                    word[i] = _word[i];
                    Word = new string(word);
                }
            }   
        }
    }
}
