using System;
namespace LibraryClass
{
    class Gigante 
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica();
        
        
        public Equipamineto Objeto = null;
        public Gigantes(string nombre)
        {
            this.Nombre = nombre;
            
            this.Estadisticas.Ataque = 80;
            this.Estadisticas.Defensa = 100;
            this.Estadisticas.Magia = 0;
            this.Estadisticas.DefensaMagica = 0;
            this.Estadisticas.PuntosDeVida = 90;
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

        public void EquiparObjeto(Equipamiento objeto)
        {
            if (this.Objeto == null)
            {
                this.Objeto = objeto;
                this.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                this.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
                this.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                this.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                this.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
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
                this.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                this.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
                this.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                this.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                this.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
            }
            else 
            {
                Console.WriteLine("No hay objetos que se puedan desequipar");
            }
        }
    }
}