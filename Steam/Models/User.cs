using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class User
    {   
        //Add getGame for single game etc.
        [Key]
        public int Id { get; set; }
        public String nickname { get; set; }
        public string avatar { get; set; }
        public String info { get; set; }
        public int level { get; set; }
        public List<Game> ownedGames { get; set; }
        public List<Game> wishlistedGames { get; set; }
        public List<Review> reviews { get; set; }
        private List<Comment> comments { get; set; }
        public User()
        {
            info = "No information given.";
            this.level = 1;
            this.ownedGames = new List<Game>();
            this.wishlistedGames = new List<Game>();
            this.reviews = new List<Review>();
            this.comments = new List<Comment>();
        }
        /*public String getNickname()
        {
            return this.nickname;
        }
        public void setNickname(String nickname)
        {
            this.nickname = nickname;
        }
        public Image getAvatar()
        {
            return this.avatar;
        }
        public void setAvatar(Image avatar)
        {
            this.avatar = avatar;
        }
        public String getInfo()
        {
            return this.info;
        }
        public void setInfo(String info)
        {
            this.info = info;
        }
        public int getLevel()
        {
            return this.level;
        }
        public void setLevel(int level)
        {
            this.level = level;
        }
        public List<Game> getOwnedGames()
        {
            return this.ownedGames;
        }
        public void setOwnedGames(List<Game> ownedGames)
        {
            if (this.ownedGames.Count == 0)
            {
                this.ownedGames = ownedGames;
            }
            else
            {
                foreach(Game g in this.ownedGames)
                {
                    this.ownedGames.Add(g);
                }
            }
        }
        public void addToOwned(Game game)
        {
            if(!this.ownedGames.Contains(game))
                this.ownedGames.Add(game);
        }
        public void setWishlistedGames(List<Game> wishlistedGames)
        {
            if (this.wishlistedGames.Count == 0)
                this.wishlistedGames = wishlistedGames;
            else
            {
                foreach(Game g in wishlistedGames)
                {
                    this.wishlistedGames.Add(g);
                }
            }
        }
        public List<Game> getWishlistedGames()
        {
            return this.wishlistedGames;
        }
        public void addToWishlist(Game game)
        {
            if (!this.wishlistedGames.Contains(game))
            {
                this.wishlistedGames.Add(game);
            }
        }
        public void setReviews(List<Review> reviews)
        {
            if (this.reviews.Count==0)
            {
                this.reviews = reviews;
            }
            else
            {
                foreach(Review r in reviews)
                {
                    this.reviews.Add(r);
                }
            }
        }
        public List<Review> GetReviews()
        {
            return this.reviews;
        }
        public void addReview(Review review)
        {
            this.reviews.Add(review);
        }
        public List<Comment> getComments()
        {
            return this.comments;
        }
        public void setComments(List<Comment> comments)
        {
            if (this.comments.Count == 0)
            {
                this.comments = comments;
            }
            else
            {
                foreach(Comment c in comments)
                {
                    this.comments.Add(c);
                }
            }
        }
        public void addComment(Comment comment)
        {
            this.comments.Add(comment);
        }*/
    }
}