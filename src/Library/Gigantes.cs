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
<<<<<<< HEAD
=======
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
>>>>>>> efd2a1f22fdeba0c8327e93f33ff2ec9cff77d7a
    }
}