using AulaInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaInterface.Entidades
{
    class Pessoa : IMetodos<Pessoa>
    {
        public void Alterar(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(object id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> Lista()
        {
            throw new NotImplementedException();
        }

        public Pessoa Obter(object id)
        {
            throw new NotImplementedException();
        }
    }
}
