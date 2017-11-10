using System.Collections.Generic;
using MyWebAPI.BL.ModelsContract;

namespace MyWebAPI.BL.Services.Intefaces
{
    public interface IClientService
    {
        IList<ClientContract> GetAllClients();
        
        ClientContract GetClientById(int id);

        void AddClient(ClientContract client);

        void UpdateClient(ClientContract client);

        void DeleteClient(int id);
    }
}
