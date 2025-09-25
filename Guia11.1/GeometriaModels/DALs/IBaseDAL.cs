using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.DALs.Utilities;

namespace GeometriaModels.DALs;

public interface IBaseDAL<E, K, T>
{
    Task<List<E>> GetAll(ITransactionDAL<T>? transaccion = null);
    Task<E?> GetByKey(K id, ITransactionDAL<T>? transaccion = null);
    Task<E?> Add(E nuevo, ITransactionDAL<T>? transaccion = null);
    Task<bool> Save(E actualizar, ITransactionDAL<T>? transaccion = null);
    Task<bool> Remove(K id, ITransactionDAL<T>? transaccion = null);
}