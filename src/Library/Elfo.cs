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
            personajeAtacado.Estadisticas.PuntosDeVida += this.Estadisticas.Magia;
        }

        public void Curar (Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida += this.Estadisticas.Magia;
        }

        public void Curar (Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida += this.Estadisticas.Magia;
        }        
    }
}