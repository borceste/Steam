using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Review
    {
        private User user;
        private String review;
        private float rating;
        private DateTime date;
        public Review()
        {
            date = DateTime.Now;
        }
        public Review(User user,String review,float rating)
        {
            this.user = user;
            this.review = review;
            this.rating = rating;
            this.date = DateTime.Now;
        }
        public void setUser(User user)
        {
            this.user = user;
        }
        public void setReview(String review)
        {
            this.review = review;
        }
        public void setRating(float rating)
        {
            this.rating = rating;
        }
        public User getUser()
        {
            return user;
        }
        public String getReview()
        {
            return review;
        }
        public float getRating()
        {
            return rating;
        }
        public DateTime getDate()
        {
            return this.date;
        }
    }
}