using System.Data.Entity;

namespace GPE.Repository
{
    public class Repository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        public Repository(DbContext context) : base(context)
        {
        }
    }
}
