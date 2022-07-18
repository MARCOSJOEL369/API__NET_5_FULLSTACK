using API__NET_5_FULLSTACK.models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API__NET_5_FULLSTACK.repositorios
{
    interface IPlayerNbaRepositorio
    {
        Task<List<PlayerNbaDto>> GetPlayers();

        Task<PlayerNbaDto> GetPlayerById(int id);

        Task<PlayerNbaDto> CreateUpdate(PlayerNbaDto PlayerNbaDto);

        Task<bool> DeletePlayer(int id);

    }
}
