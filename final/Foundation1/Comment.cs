using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation1
{
    internal class Comment
    {
        private string _name;
        private string _comment;

        public Comment(string name, string comment)
        {
            _name = name;
            _comment = comment;
        }

        public string GetComment()
        { return $"{_name} - {_comment}"; }
    }
}
