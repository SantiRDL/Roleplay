using System;
using LibraryClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipamiento espada = new Equipamiento("espada", "arma", 0, 10, 0, 0 ,0);
            Equipamiento capa = new Equipamiento("capa", "ropaje", 0, 0, 0, 10 ,10);

            Equipamiento arco = new Equipamiento("Arco", "arma", 0, 30, 0, 0, 0 );
            Equipamiento martillo = new Equipamiento("Martillo", "arma", 0, 25, 0, 0, 0 );


        }
    }
}
