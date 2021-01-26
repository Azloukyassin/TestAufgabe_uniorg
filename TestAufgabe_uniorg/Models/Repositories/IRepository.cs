using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAufgabe_uniorg.Controllers.Repsotories
{
    /// <summary>
    /// Hier wurde Repository implementiert 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    interface IRepository<TEntity>
    {
        IList<TEntity> liste();
        // TEntity Find(int id);
        void Add(TEntity entity);
        // void Update(int id, TEntity entity);
        // void Delete(int id);
    }
}
