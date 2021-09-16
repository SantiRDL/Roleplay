using System;

namespace LibraryClass
{
    class Enanos
    {
        public Estadistica Estadistica;
        public Equipamiento Objeto;
        public string Nombre;

        public Enanos(string nombre)
        {
            this.Nombre = nombre;
            
        }

        this.Estadistica = new Estadistica;
        this.Estadistica.Ataque = 80;
        this.Estadistica.PuntosDeVida = 100;
        this.Estadistica.Magia = 0;
        this.Estadistica.Defensa = 60;
        this.Estadistica.DefensaMagica = 60;


        public void AtaqueFisico(gigante personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadistica.PuntosDeVida - this.Estadistica.Ataque;
        }
        public void AtaqueFisico(mago personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadistica.PuntosDeVida - this.Estadistica.Ataque;
        }
        public void AtaqueFisico(elfo personajeAtacado)
        {
            personajeAtacado.Estadistica.PuntosDeVida = personajeAtacado.Estadistica.PuntosDeVida - this.Estadistica.Ataque;
        }
        
        
        
        public void EquiparObjeto(Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadistica.Ataque = 80 + objeto.Estadistica.Ataque;
            this.Estadistica.PuntosDeVida = 100 + objeto.Estadistica.PuntosDeVida;
            this.Estadistica.Magia = 0 + objeto.Estadistica.Magia;
            this.Estadistica.Defensa = 60 + objeto.Estadistica.Defensa;
            this.Estadistica.DefensaMagica = 60 + objeto.Estadistica.DefensaMagica;
            

        }

        public void DesequiparObjeto(Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadistica.Ataque = 80 - objeto.Estadistica.Ataque;
            this.Estadistica.PuntosDeVida = 100 - objeto.Estadistica.PuntosDeVida;
            this.Estadistica.Magia = 0 - objeto.Estadistica.Magia;
            this.Estadistica.Defensa = 60 - objeto.Estadistica.Defensa;
            this.Estadistica.DefensaMagica = 60 - objeto.Estadistica.DefensaMagica;
        }
    }











}