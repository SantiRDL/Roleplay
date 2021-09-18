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
        

        public void AtaqueFisico(Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
        public void AtaqueFisico(Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
        public void AtaqueFisico(Elfo personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
<<<<<<< HEAD
=======
        //Obt
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
>>>>>>> efd2a1f22fdeba0c8327e93f33ff2ec9cff77d7a
    }
}