using System.Data.Entity;

namespace GPE.Repository
{
    public class UnitOfWork: BaseUnitOfWork
    {
        public UnitOfWork(DbContext context) : base(context)
        {
        }
    }
}
