using SportsApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsApp.Services
{
    public interface IPositionService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
