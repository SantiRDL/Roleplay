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

            Estadistica e1 = new Estadistica(0, 0, 0, 30, 30);
            Equipamiento escudo = new Equipamiento("escudo", "arma", e1);
            Estadistica e2 = new Estadistica(0, 0, 0, 10 ,10);
            Equipamiento botas = new Equipamiento("botas", "ropaje", e2);

        }
    }
}
