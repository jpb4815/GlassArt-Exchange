using System;

namespace GPE.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
