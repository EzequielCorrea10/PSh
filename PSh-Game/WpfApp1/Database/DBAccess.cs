using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfApp1.Model;

namespace WpfApp1.Database
{
    public class DBAccess : DbContext
    {
        public DBAccess() : base("name=MySqlConnection")
        {
        }

        public DbSet<Player> Players { get; set; }


        public void InsertPlayer(Player player)
        {
            using (var context = new DBAccess())
            {
                context.Players.Add(player);
                context.SaveChanges();
            }
        }

        public void UpdatePlayer(Player player) {
            using (var context = new DBAccess())
            {
                var playerFound = context.Players.Find(player.Id);
                if (playerFound != null)
                {
                    playerFound = player;
                    context.SaveChanges();
                }
            }
        }


        public void RemovePlayer(int id)
        {
            using (var context = new DBAccess())
            {
                var player = context.Players.Find(id);
                if (player != null)
                {
                    context.Players.Remove(player);
                    context.SaveChanges();
                }
            }
        }

        public Player GetPlayer(int id)
        {
            using (var context = new DBAccess())
            {
                var player = context.Players.Find(id);
                if (player != null)
                {
                    return player;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Player> GetAllPlayers()
        {
            using (var context = new DBAccess())
            {
                var players = context.Players;
                return players.ToList();
            }
        }

        public List<Player> GetTopPlayers(int quantity)
        {
            using (var context = new DBAccess())
            {
                var players = context.Players.OrderByDescending(p=> p.Score).Take(quantity);
                return players.ToList();
            }
        }
    }
}
