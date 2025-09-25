using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs.Utilities
{
    public interface IFigurasDAL<T> : IBaseDAL<FiguraModel, int, T>
    {
        //agregar métodos específicos
        Task ProcesarFiguras(ITransactionDAL<T>? transaccion = null);
    }
}
