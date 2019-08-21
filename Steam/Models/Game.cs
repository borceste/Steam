using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Steam.Models
{
    public class Game
    {
        private String name;
        private float price;
        private List<Image> images;
        private String description;
        private String developer;
        private float rating;
        private List<Review> reviews;
        private float discount;
        private Genre genre;
        public Game()
        {
            discount = 0;
            price = 0;
            images = new List<Image>();
            reviews = new List<Review>();
        }

        

        public String getName()
        {
            return name;
        }
        public float getPrice()
        {
            if(discount!=0)
                return price/discount;
            return price;
        }
        public List<Image> getImages()
        {
            return images;
        }

        public String getDescription()
        {
            return description;
        }
        public String getDeveloper()
        {
            return developer;
        }
        public float getRating()
        {
            return rating;
        }
        public List<Review> GetReviews()
        {
            return reviews;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public void setImages(List<Image> images)
        {
            this.images = images;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setDeveloper(String developer)
        {
            this.developer = developer;
        }
        public void setRating(float rating)
        {
            this.rating = rating;
        }
        public void setReviews(List<Review> reviews)
        {
            if(reviews.Count==0)
                this.reviews = reviews;
            else
            {
                foreach(Review review in reviews)
                {
                    this.reviews.Add(review);
                }
            }
        }
        public void addReview(Review review)
        {
            reviews.Add(review);
        }

        public void calculateRating()
        {
            float sum = 0;
            foreach(Review r in this.reviews)
            {
                sum += r.getRating();
            }
            rating = sum / this.reviews.Count;
        }
        public void addImage(Image image)
        {
            this.images.Add(image);
        }
        public void setGenre(Genre genre)
        {
            this.genre = genre;
        }
        public Genre getGenre()
        {
            return this.genre;
        }
    }
}