using System;
using System.Collections.Generic;
using System.Linq;
using MyWebAPI.BL.ModelsContract;
using MyWebAPI.BL.Services.Intefaces;
using MyWebAPI.DL.Entities;
using WebAPI.DAL.Repositories;
using WebAPI.DAL.Repositories.Base;

namespace MyWebAPI.BL.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = new UnitOfWork();
        }
        //public ClientService()
        //{
        //    _unitOfWork = new UnitOfWork();
        //}
        public void AddClient(ClientContract client)
        {
            var clientTmp = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName
            };
            _unitOfWork.ClientRepository.Create(clientTmp);
        }

        public void DeleteClient(ClientContract client)
        {
            var findClient = _unitOfWork.ClientRepository.GetAll().FirstOrDefault(cl =>
                cl.FirstName == client.FirstName && cl.LastName == client.LastName);
            if (findClient != null)
            {
                _unitOfWork.ClientRepository.Delete(findClient.Id);
            }
        }

        public void DeleteClient(int id)
        {
            _unitOfWork.ClientRepository.Delete(id);
        }

        public void DeleteClientById(int id)
        {
            _unitOfWork.ClientRepository.Delete(id);
        }

        public IList<ClientContract> GetAllClients()
        {
            var clients = new List<ClientContract>();
            foreach (var client in _unitOfWork.ClientRepository.GetAll())
            {
                clients.Add(new ClientContract()
                {
                  FirstName  = client.FirstName,
                  LastName = client.LastName
                });
            }
            if (clients == null)
                return null;

            return clients;
        }

        public ClientContract GetClientById(int id)
        {
            var client = _unitOfWork.ClientRepository.GetItemById(id);
            if (client != null)
            {
                var clientContract = new ClientContract()
                {
                    FirstName = client.FirstName,
                    LastName = client.LastName
                };
                return clientContract;
            }
            return null;
        }

        public void UpdateClient(ClientContract clientContract)
        {
            var client = new Client()
            {
                FirstName = clientContract.FirstName,
                LastName = clientContract.LastName
                    
            };
            _unitOfWork.ClientRepository.Update(client);
        }
    }
}
