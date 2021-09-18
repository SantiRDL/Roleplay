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

            Estadistica i1 = new Estadistica(0, 30, 0, 0, 0);
            Estadistica i2 = new Estadistica(0, 25, 0, 0, 0);
            Equipamiento arco = new Equipamiento("Arco", "arma", i1);
            Equipamiento martillo = new Equipamiento("Martillo", "arma", i2 );

            

            Estadistica e1 = new Estadistica(0, 0, 0, 30, 30);
            Equipamiento escudo = new Equipamiento("escudo", "arma", e1);
            Estadistica e2 = new Estadistica(0, 0, 0, 10 ,10);
            Equipamiento botas = new Equipamiento("botas", "ropaje", e2);

        }
    }
}
