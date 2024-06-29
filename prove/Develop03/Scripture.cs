using System;
using System.Text;

namespace Develop03
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture (Reference reference, string text)
        {
            _reference = reference;
            string[] fullText = text.Split (' ');
            foreach (string word in fullText)
            { 
                _words.Add(new Word(word));
            }
        }

        public Reference GetReference()
        { return _reference; }

        public void HideRandomWords(int numToHide)
        {
            var rand = new Random();
            while (numToHide != 0 && !isHidden())
            {
                int _randomNum = rand.Next(0, _words.Count);
                if (!_words[_randomNum].IsHidden())
                {
                    _words[_randomNum].Hide();
                    numToHide--;
                }
            }
        }

        public string GetText()
        {
            StringBuilder result = new StringBuilder();

            foreach (var word in _words)
            {
                if (word.IsHidden())
                {
                    foreach (char c in word.GetWord())
                    {
                        if (char.IsLetter(c))
                        {
                            result.Append('_');
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                    result.Append(" ");
                }
                else
                {
                    result.Append(word.GetWord() + " ");
                }
            }

            return result.ToString().Trim();
        }

        public bool isHidden()
        {
            for(int i = 0; i < _words.Count; i++) 
            { 
                if (!_words[i].IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
