using SportsApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsApp.Services
{
    public interface IPlayersService
    {
        Task<IEnumerable<Player>> GetPlayersList();
        Task<Player> GetPlayerById(int id);

        Task<Player> createPlayer(Player player);

        Task updatePlayer(Player player);

        Task deletePlayer(Player player);
    }
}
