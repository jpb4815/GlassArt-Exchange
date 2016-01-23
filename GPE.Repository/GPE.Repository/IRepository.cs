using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPE.Repository
{
    public interface IRepository<T>: IDisposable
    {
        IEnumerable<T> GetList();
        T Get(int id);
        void Insert(T item);
        void Delete(int id);
        void Update(T item);
        void Save();
    }
}
