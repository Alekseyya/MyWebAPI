using System;

namespace WebAPI.DAL.Repositories.Base
{
    public interface IUnitOfWork: IDisposable
    {
        IClientRepository ClientRepository { get; set; }
    }
}
