using System;

namespace LibraryClass
{
    class Enano
    {
        public Estadistica Estadisticas = new Estadistica(80, 100, 0, 60, 60);
        public Equipamiento Objeto;
        public string Nombre;

        public Enano(string nombre)
        {
            this.Nombre = nombre;
            
            this.Estadisticas.Ataque = 80;
            this.Estadisticas.PuntosDeVida = 100;
            this.Estadisticas.Magia = 0;
            this.Estadisticas.Defensa = 60;
            this.Estadisticas.DefensaMagica = 60;
        }
        
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
    }
}