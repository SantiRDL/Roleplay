using System;
namespace LibraryClass
{
    class Gigante 
    {
        public string Nombre;
        public Estadistica Estadistica = new Estadistica;
        this.Estadistica.Ataque = 80;
        this.Estadistica.Defensa = 100;
        this.Estadistica.PuntosDeVida = 90;
        
        public Equipamineto Objeto = null;
        public Gigantes (string nombre)
        {
            this.Nombre = nombre;
        }

        public void AtaqueFisico (Enano personajeAtacado))
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadistica.Ataque;
        }

        public void AtaqueFisico (Elfo personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadistica.Ataque;
        }

        public void AtaqueFisico (Mago personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadistica.Ataque;
        }

        public void EquiparObjeto (Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadistica.Ataque = 80 + objeto.Estadistica.Atque;
            this.Estadistica.Defensa = 100 + objeto.Estadistica.Defensa;
            this.Estadistica.PuntosDeVida = 90 + objeto.Estadistica.PuntosDeVida;       
        }

        public void DesequiparObjeto (Equipamiento objeto)
        {
            if (this.Objeto != null)
            {
                this.Objeto = null;
                 this.Estadistica.Ataque = 80 - objeto.Estadistica.Atque;
            this.Estadistica.Defensa = 100 - objeto.Estadistica.Defensa;
            this.Estadistica.PuntosDeVida = 90 - objeto.Estadistica.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar")
            }
        }
    }
}