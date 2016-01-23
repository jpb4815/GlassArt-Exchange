using System;
using System.Data.Entity;

namespace GPE.Repository
{
    public abstract class BaseUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private bool _disposed;

        protected BaseUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}