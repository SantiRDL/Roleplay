using System;

namespace LibraryClass
{
    public class Elfo 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica(50, 50, 50, 50, 90);

        
        public Equipamiento Objeto = null;
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
        }

        

        public void Curar (Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = 80;
        }

        public void Curar (Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = 90;
        }

        public void Curar (Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida += this.Estadisticas.Magia;
        } 
        
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
    }
}