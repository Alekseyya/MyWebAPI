using System;

namespace WebAPI.DAL.Repositories.Base
{
    public interface IUnitOfWork
    {
        IClientRepository ClientRepository { get; set; }
    }
}
