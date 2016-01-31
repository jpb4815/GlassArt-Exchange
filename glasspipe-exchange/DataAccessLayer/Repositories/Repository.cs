using System.Data.Entity;

namespace DataAccessLayer.Repositories
{
    public class Repository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        public Repository(DbContext context) : base(context)
        {
        }
    }
}
