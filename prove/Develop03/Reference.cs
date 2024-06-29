using System;

namespace Develop03
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = verse;
        }
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public string GetText()
        {
            if (_endVerse != _startVerse)
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            else
                return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}
