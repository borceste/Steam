using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Genre
    {
        private String name;
        private List<Game> games;
        public Genre()
        {
            games = new List<Game>();
        }
        public Genre(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public List<Game> getGames()
        {
            return this.games;
        }
        public void setGames(List<Game> games)
        {
            if (this.games.Count == 0)
            {
                this.games = games;
            }
            else
            {
                foreach(Game g in games)
                {
                    this.games.Add(g);
                }
            }
        }
        public void addGame(Game game)
        {
            if (!this.games.Contains(game))
            {
                this.games.Add(game);
            }
        }
    }
}