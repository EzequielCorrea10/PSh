using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Services;

namespace WpfApp1.Controllers
{
    public class PlayerController
    {
        PlayerService playerService = new PlayerService();

        public List<Player> GetPlayers(int? quantity)
        {
            if (quantity.HasValue) { 
                return playerService.GetTopPlayers(quantity.Value);
            }
            else
            {
                return playerService.GetAllPlayers();
            }
        }

        public Player GetPlayerById(int id)
        {
            return playerService.GetPlayer(id);
        }

        public void InsertPlayer(Player player)
        {
            playerService.InsertPlayer(player);
        }
    }
}
