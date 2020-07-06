using AulaInterface.Interfaces;
using System;

namespace AulaInterface.Entidades
{
    class Documento : IAcesso, IComprimir
    {
        #region IComprimir
        public void Comprimir()
        {
            Console.WriteLine("Comprimir ...");
        }

        public void Descomprimir()
        {
            Console.WriteLine("Descomprimir ...");
        }
        #endregion
        #region IAcesso
        public void Escrever()
        {
            Console.WriteLine("Escrever ...");
        }

        public void Ler()
        {
            Console.WriteLine("Ler ...");
        }
        #endregion

    }
}
