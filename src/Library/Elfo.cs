using System;

namespace LibraryClass
{
    class Elfo 
    {
        public string Nombre;
        public Estadistica Estadistica = new Estadistica;
        this.Estadistica.Ataque = 50;
        this.Estadistica.Magia = 50;
        this.Estadistica.Defensa = 50;
        this.Estadistica.DefensaMagica =50;
        this.Estadistica.PuntosDeVida = 90;
        
        public Equipamineto Objeto = null;
        public Elfos (string nombre)
        {
            this.Nombre = nombre;
        }

        public void AtaqueFisico (Enano personajeAtacado))
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.Ataque;
        }

        public void AtaqueFisico (Gigante personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.Ataque;
        }

        public void AtaqueFisico (Mago personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.Ataque;
        }

        public void AtaqueMagico (Enano personajeAtacado))
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.AtaqueMagico;
        }

        public void AtaqueMagico (Gigante personajeAtacado))
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.AtaqueMagico;
        }

        public void AtaqueMagico (Mago personajeAtacado))
        {
            personajeAtacado.Estadistica.PuntosDeVida -= this.Estadistica.AtaqueMagico;
        }

        public void Curar (Enano personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida += this.Estadistica.Magia;
        }

        public void Curar (Gigante personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida += this.Estadistica.Magia;
        }

        public void Curar (Mago personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida += this.Estadistica.Magia;
        }

        

        public void EquiparObjeto (Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadistica.Ataque += objeto.Estadistica.Ataque;
            this.Estadistica.Magia += objeto.Estadistica.Magia;
            this.Estadistica.Defensa += objeto.Estadistica.Defensa;
            this.Estadistica.DefensaMagica += objeto.Estadistica.DefensaMagica;
            this.Estadistica.PuntosDeVida += objeto.Estadistica.PuntosDeVida;       
        }

        public void DesequiparObjeto (Equipamiento objeto)
        {
            if (this.Objeto != null)
            {
                this.Objeto = null;
                this.Estadistica.Ataque -= objeto.Estadistica.Ataque;
                this.Estadistica.Magia -= objeto.Estadistica.Magia;
                this.Estadistica.Defensa -= objeto.Estadistica.Defensa;
                this.Estadistica.DefensaMagica -= objeto.Estadistica.DefensaMagica;
                this.Estadistica.PuntosDeVida -= objeto.Estadistica.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar")
            }
        }
    }
}