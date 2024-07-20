using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation1
{
    internal class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        { _comments.Add(comment); }

        public int GetNumComments()
        { return _comments.Count; }

        public string GetDisplayInfo()
        { return $"\n{_title} - By: {_author} - {GetNumComments()} Comments\n"; }

        public void PrintComments()
        {
            foreach (Comment comment in _comments) 
                System.Console.WriteLine(comment.GetComment());
        }
    }
}
