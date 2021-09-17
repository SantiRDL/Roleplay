using System;
namespace LibraryClass
{
    class Gigante 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica();
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

        public void EquiparObjeto(Equipamiento objeto)
        {
            if (this.Objeto = null)
            {
                this.Objeto = objeto;
                this.Estadisticas.Ataque += objeto.Estadisticas.Ataque;
                this.Estadisticas.PuntosDeVida += objeto.Estadisticas.PuntosDeVida;
                this.Estadisticas.Magia += objeto.Estadisticas.Magia;
                this.Estadisticas.Defensa += objeto.Estadisticas.Defensa;
                this.Estadisticas.DefensaMagica += objeto.Estadisticas.DefensaMagica;
            }
            else
            {
                Console.WriteLine("Ya hay un objeto equipado.");
            }
        }

        public void DesequiparObjeto(Equipamiento objeto)
        {
            if (this.Objeto != null)
            {
                this.Objeto = null;
                this.Estadisticas.Ataque -= objeto.Estadisticas.Ataque;
                this.Estadisticas.PuntosDeVida -= objeto.Estadisticas.PuntosDeVida;
                this.Estadisticas.Magia -= objeto.Estadisticas.Magia;
                this.Estadisticas.Defensa -= objeto.Estadisticas.Defensa;
                this.Estadisticas.DefensaMagica -= objeto.Estadisticas.DefensaMagica;
            }
            else 
            {
                Console.WriteLine("No hay objetos que se puedan desequipar");
            }
        }
    }
}