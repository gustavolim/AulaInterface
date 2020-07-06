using System;
using System.Collections.Generic;
using System.Text;

namespace AulaInterface.Interfaces
{
    interface IMetodos<T> where T : class
    {
        void Incluir(T entidade);
        void Alterar(T entidade);
        void Excluir(object id);
        T Obter(object id);
        IEnumerable<T> Lista();
    }
}
