using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class Comment
    {
        private string comment;
        public Comment(string comment_input)
        {
            comment = comment_input;
        }
        public Comment()
        {
            comment = "";
        }
        public void Setcomment(string comment_input)
        {
            comment = comment_input;
        }
        public string Getcomment()
        {
            return comment;
        }
    }
}
