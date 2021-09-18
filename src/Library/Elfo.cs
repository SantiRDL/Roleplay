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
            personajeAtacado.Estadisticas.PuntosDeVida = 70;
        }

        

        public void EquiparObjeto (Equipamiento objeto)
        {
            if (this.Objeto == null)
            {
                this.Objeto = objeto;
                this.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                this.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                this.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                this.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
                this.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
            }       
        }

        public void DesequiparObjeto (Equipamiento objeto)
        {
            if (this.Objeto != null)
            {
                this.Objeto = null;
                this.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                this.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                this.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                this.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
                this.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar");
            }
        }
    }
}