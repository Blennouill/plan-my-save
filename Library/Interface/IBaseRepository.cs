using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Library.Interface
{
    public interface IBaseRepository<M> where M : class, IEntity
    {
        IEnumerable<M> SelectAll();

        M SelectByID(int id);

        void Insert(M obj);

        void Update(M obj);

        void Delete(int id);

        void Save();
    }
}
