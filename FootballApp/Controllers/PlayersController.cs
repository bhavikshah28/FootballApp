using Microsoft.AspNetCore.Mvc;
using SportsApp.Models;
using SportsApp.Services;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SportsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly IPlayersService _playersService;

        public PlayersController(IPlayersService playersService)
        {
            _playersService = playersService;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> Get()
        {
            return await _playersService.GetPlayersList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> Get(int id)
        {
            var player = await _playersService.GetPlayerById(id);

            if(player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<Player>> POST(Player player)
        {
            await _playersService.createPlayer(player);
            return CreatedAtAction("post", new { id = player.Id }, player);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Player>> PUT(int id,Player player)
        {
            if(id != player.Id)
            {
                return BadRequest("Not a valid Player Id");
            }
            await _playersService.updatePlayer(player);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid player id");

            var player = await _playersService.GetPlayerById(id);
            if (player == null)
            {
                return NotFound();
            }

            await _playersService.deletePlayer(player);

            return NoContent();
        }
    }
}
