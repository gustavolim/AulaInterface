using AulaInterface.Entidades;
using AulaInterface.Interfaces;
using System;

namespace AulaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAcesso acesso = new Documento();
            acesso.Ler();
            acesso.Escrever();

            IComprimir comprimir = new Documento();
            comprimir.Comprimir();
            comprimir.Descomprimir();
            Console.ReadKey();
        }
    }
}
