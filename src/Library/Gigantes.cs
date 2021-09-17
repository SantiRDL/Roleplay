using System;
namespace LibraryClass
{
    class Gigante 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica;
        this.Estadistica.Ataque = 80;
        this.Estadistica.Defensa = 100;
        this.Estadistica.Magia = 0;
        this.Estadistica.DefensaMagica = 0;
        this.Estadistica.PuntosDeVida = 90;
        
        public Equipamineto Objeto = null;
        public Gigantes (string nombre)
        {
            this.Nombre = nombre;
        }

        public void AtaqueFisico (Enano personajeAtacado))
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }

        public void AtaqueFisico (Elfo personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }

        public void AtaqueFisico (Mago personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }

        public void EquiparObjeto (Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadisticas.Ataque = 80 + objeto.Estadisticas.Atque;
            this.Estadisticas.Defensa = 100 + objeto.Estadisticas.Defensa;
            this.Estadisticas.PuntosDeVida = 90 + objeto.Estadisticas.PuntosDeVida;       
        }

        public void DesequiparObjeto (Equipamiento objeto)
        {
            if (this.Objeto != null)
            {
                this.Objeto = null;
                this.Estadisticas.Ataque = 80 - objeto.Estadisticas.Atque;
                this.Estadisticas.Defensa = 100 - objeto.Estadisticas.Defensa;
                this.Estadisticas.PuntosDeVida = 90 - objeto.Estadisticas.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar")
            }
        }
    }
}