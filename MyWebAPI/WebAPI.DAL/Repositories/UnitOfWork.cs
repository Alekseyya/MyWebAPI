﻿using MyWebAPI.DL.Context;
using WebAPI.DAL.Repositories.Base;

namespace WebAPI.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MyDbConnection _context;

        public IClientRepository ClientRepository { get; set; }

        public UnitOfWork()
        {
            _context = new MyDbConnection(); //вот тут неуверен что делаю правильно
            ClientRepository = new ClientRepository(_context);
        }



        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            //db.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
