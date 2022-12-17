using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windowswebgsm.Data;

namespace windowswebgsm.data.Services
{
    public class GameServerService
    {
        private readonly AppDbContext _appDbContext;

        public GameServerService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        #region Inserting Logic
        public async Task<bool> InsertGameServerAsync(GameServer gameServer)
        {
            await _appDbContext.GameServers.AddAsync(gameServer);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Fetching Logic
        public async Task<List<GameServer>> GetAllGameServersAsync()
        {
            return await _appDbContext.GameServers.ToListAsync();
        }
        public async Task<GameServer> GetGameServerById(string id)
        {
            GameServer gameServer = await _appDbContext.GameServers.FirstOrDefaultAsync(c => c.ID.Equals(id));
            return gameServer;
        }
        #endregion

        #region Update Logic
        public async Task<bool> UpdateGameServerAsync(GameServer gameServer)
        {
            _appDbContext.GameServers.Update(gameServer);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Deletion Logic
        public async Task<bool> DeleteGameServerAsync(GameServer gameServer)
        {
            _appDbContext.Remove(gameServer);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
