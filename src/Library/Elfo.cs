using System;

namespace LibraryClass
{
    class Elfo 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica(50, 50, 50, 50, 90);

        
        public Equipamiento Objeto = null;
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AtaqueFisico (Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Ataque;
        }

        public void AtaqueFisico (Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Ataque;
        }

        public void AtaqueFisico (Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Ataque;
        }

        public void AtaqueMagico (Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Magia;
        }

        public void AtaqueMagico (Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Magia;
        }

        public void AtaqueMagico (Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida -= this.Estadisticas.Magia;
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
<<<<<<< HEAD
            personajeAtacado.Estadisticas.PuntosDeVida += this.Estadisticas.Magia;
        }        
=======
            personajeAtacado.Estadisticas.PuntosDeVida = 70;
        }
        
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
>>>>>>> efd2a1f22fdeba0c8327e93f33ff2ec9cff77d7a
    }
}