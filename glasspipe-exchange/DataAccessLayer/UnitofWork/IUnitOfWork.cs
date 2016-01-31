using System;

namespace DataAccessLayer.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
