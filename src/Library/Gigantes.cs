using System;
namespace LibraryClass
{
    class Gigante 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica(90, 80, 0, 100, 0);
        
        
        public Equipamiento Objeto = null;
        public Gigante(string nombre)
        {
            this.Nombre = nombre;
            
        }

        public void AtaqueFisico(Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }

        public void AtaqueFisico(Elfo personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }

        public void AtaqueFisico(Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
    }
}