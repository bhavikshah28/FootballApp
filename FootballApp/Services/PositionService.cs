using Microsoft.EntityFrameworkCore;
using SportsApp.Data;
using SportsApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApp.Services
{
    public class PositionService : IPositionService
    {
        private readonly FootballDbContext _footballdbcontext;

        public PositionService(FootballDbContext footballdbcontext)
        {
            _footballdbcontext = footballdbcontext;
        }

        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _footballdbcontext.Positions.OrderBy(x => x.DisplayOrder).ToListAsync();
        }
    }
}
