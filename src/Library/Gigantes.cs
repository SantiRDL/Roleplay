using System;
namespace LibraryClass
{
    public class Gigante 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica(90, 80, 0, 100, 0);
        
        
        public Equipamiento Objeto = null;
        public Gigante(string nombre)
        {
            this.Nombre = nombre;
            
        }

        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
    }
}