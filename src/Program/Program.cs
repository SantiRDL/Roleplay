using System;
using LibraryClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Estadistica uno = new Estadistica(0, 10, 0, 0 ,0);
            Equipamiento espada = new Equipamiento("espada", "arma", uno);
            Estadistica dos = new Estadistica(0, 0, 0, 10 ,10);
            Equipamiento capa = new Equipamiento("capa", "ropaje", dos);

        }
    }
}
