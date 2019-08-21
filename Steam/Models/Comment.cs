using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Comment
    {
        private User user;
        private String comment;
        private DateTime date;
        public Comment()
        {
            date = DateTime.Now;
        }
        public Comment(User user, String comment)
        {
            this.user = user;
            this.comment = comment;
            this.date = DateTime.Now;
        }
        public void setUser(User user)
        {
            this.user = user;
        }
        public void setComment(String comment)
        {
            this.comment = comment;
        }
        public User getUser()
        {
            return user;
        }
        public String getComment()
        {
            return comment;
        }
        public DateTime getDate()
        {
            return this.date;
        }
    }
}