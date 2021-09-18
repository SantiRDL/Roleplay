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
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
    }
}