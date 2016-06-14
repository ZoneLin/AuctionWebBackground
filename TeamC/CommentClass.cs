﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace TeamC
{
    class CommentClass
    {
        private string commentcontent;
        private string commentuserID;
        private DateTime date;
        public CommentClass(string newContent="", string newUserID="")
        {
            // TODO: Complete member initialization
            this.commentcontent = newContent;
            this.commentuserID = newUserID;
            this.date = DateTime.Now;
        }

        public string getCommentDate()
        {
            return date.ToString("G", CultureInfo.InvariantCulture);
        }

        public string getCommentContent()
        {
            return commentcontent;
        }
    }
}
