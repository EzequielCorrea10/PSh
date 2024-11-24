using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Database;
using WpfApp1.Model;

namespace WpfApp1.Services
{
    public class PlayerService
    {
        DBAccess dBAccess;
        public PlayerService() {
            dBAccess = new DBAccess();
        }

        public void UpdatePlayer(Player player)
        {
            dBAccess.UpdatePlayer(player);
        }

        public Player GetPlayer(int id)
        {
            return dBAccess.GetPlayer(id);
        }

        public void RemovePlayer(int id)
        {
            dBAccess.RemovePlayer(id);
        }

        public void InsertPlayer(Player player)
        {
             dBAccess.InsertPlayer(player);
        }


        public List<Player> GetAllPlayers()
        {
            return dBAccess.GetAllPlayers();
        }

        public List<Player> GetTopPlayers(int quantity)
        {
            return dBAccess.GetTopPlayers(quantity);
        }
    }
}
