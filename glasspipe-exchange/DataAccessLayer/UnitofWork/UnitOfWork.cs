using System.Data.Entity;

namespace DataAccessLayer.UnitofWork
{
    public class UnitOfWork: BaseUnitOfWork
    {
        public UnitOfWork(DbContext context) : base(context)
        {
        }
    }
}
