using System;

namespace LibraryClass
{
    class Equipamiento
    {
        public string Nombre;
        public string Tipo; 

        public Estadistica EstadisticaPotenciada;

        public Equipamiento(string nombre, string tipo, Estadistica estadisticaPotenciada)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.EstadisticaPotenciada = estadisticaPotenciada;
        }
    }











}