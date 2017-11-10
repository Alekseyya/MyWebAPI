
using MyWebAPI.DL.Context;
using System;
using System.Data.Entity;
using System.Linq;
using MyWebAPI.DL.Entities;
using WebAPI.DAL.Repositories.Base;

namespace WebAPI.DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly MyDbConnection _context;

        public ClientRepository(MyDbConnection context)
        {
            _context = context;
        }
        public void Create(Client item)
        {
            _context.Clients.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Client client = _context.Clients.FirstOrDefault(o => o.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        public IQueryable<Client> GetAll()
        {
            var aa = _context.Clients.ToList();
            return _context.Clients.AsQueryable();
        }

        public Client GetItemById(int id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);
            if (client != null)
                return client;
            else
            {
                return null;
            }
        }

        public void Update(Client item)
        {
            var client = _context.Clients.FirstOrDefault(o => o.Id == item.Id);
            bool isModified = false;

            if (client.FirstName != item.FirstName)
            {
                client.FirstName= item.FirstName;
                isModified = true;
            }

            if (client.LastName != item.LastName)
            {
                client.LastName = item.LastName;
                isModified = true;
            }

            if (isModified)
            {
                _context.Entry(client).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
