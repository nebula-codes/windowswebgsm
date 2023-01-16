using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windowswebgsm.Data;
@inject GameServerService gameServerService

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
            //Validate if server already exists with same name
            List<GameServer> existingServers = await GetAllGameServersAsync();

            foreach(var server in existingServers)
            {
                if(server.Name == gameServer.Name)
                {
                    return false;
                }
            }
            //Check if Port is already in use


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


        public async Task<int> GetGameServerPidAsync(GameServer gameServer){
            if (gameServer.PID != null){
                return gameServer.PID;
            }else {
                return 0;
            }
        }
        #endregion

        #region Update Logic
        public async Task<bool> UpdateGameServerAsync(GameServer gameServer)
        {
            //Shutdown (Gracefully if possible) the server before updating.


            //Backup server files first.
            await BackupGameServerFilesAsync(gameServer);


            _appDbContext.GameServers.Update(gameServer);
            await _appDbContext.SaveChangesAsync();

            //Restart the server with the updated files.

            return true;
        }

        private async Task<bool> BackupGameServerFilesAsync(GameServer gameServer){
            // Get game path

            //Compress files for backup

            //Set in the backup directory

            //If successful return true, if not, false

            return true;
        }


        #endregion

        #region Deletion Logic
        public async Task<bool> DeleteGameServerAsync(GameServer gameServer)
        {

            //Kill the server first, THEN delete from DB. So await until process is shut down.

            //Ask user BEFORE deleting game files, in case it wants to be reused.


            _appDbContext.Remove(gameServer);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> KillGameServerAsync(GameServer gameServer) {
            return gameServerService.KillGameServerAsync();
        }

        #endregion


    }
}
