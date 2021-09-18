using System;

namespace LibraryClass
{
    class Equipamiento
    {
        public string Nombre;
        public string Tipo; 


        public Estadistica EstadisticaPotenciada;


        public Equipamiento(string nombre, string tipo, Estadistica estadisticaPotenciada)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.EstadisticaPotenciada = estadisticaPotenciada;
        }
        public void EquiparObjeto (Equipamiento objeto, Elfo personaje)
        {
            if (personaje.Objeto == null)
            {
                personaje.Objeto = objeto;
                personaje.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
            }       
        }
        public void EquiparObjeto (Equipamiento objeto, Enano personaje)
        {
            if (personaje.Objeto == null)
            {
                personaje.Objeto = objeto;
                personaje.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
            }       
        }
        public void EquiparObjeto (Equipamiento objeto, Gigante personaje)
        {
            if (personaje.Objeto == null)
            {
                personaje.Objeto = objeto;
                personaje.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
            }       
        }
        public void EquiparObjeto (Equipamiento objeto, Mago personaje)
        {
            if (personaje.Objeto == null)
            {
                personaje.Objeto = objeto;
                personaje.Estadisticas.Ataque += objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia += objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa += objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica += objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida += objeto.EstadisticaPotenciada.PuntosDeVida;
            }       
        }

        public void DesequiparObjeto (Equipamiento objeto, Elfo personaje)
        {
            if (personaje.Objeto != null)
            {
                personaje.Objeto = null;
                personaje.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar");
            }
        }
        public void DesequiparObjeto (Equipamiento objeto, Enano personaje)
        {
            if (personaje.Objeto != null)
            {
                personaje.Objeto = null;
                personaje.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar");
            }
        }
        public void DesequiparObjeto (Equipamiento objeto, Gigante personaje)
        {
            if (personaje.Objeto != null)
            {
                personaje.Objeto = null;
                personaje.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar");
            }
        }
        public void DesequiparObjeto (Equipamiento objeto, Mago personaje)
        {
            if (personaje.Objeto != null)
            {
                personaje.Objeto = null;
                personaje.Estadisticas.Ataque -= objeto.EstadisticaPotenciada.Ataque;
                personaje.Estadisticas.Magia -= objeto.EstadisticaPotenciada.Magia;
                personaje.Estadisticas.Defensa -= objeto.EstadisticaPotenciada.Defensa;
                personaje.Estadisticas.DefensaMagica -= objeto.EstadisticaPotenciada.DefensaMagica;
                personaje.Estadisticas.PuntosDeVida -= objeto.EstadisticaPotenciada.PuntosDeVida;
            }

            else
            {
                Console.WriteLine ("No hay objetos para desequipar");
            }
        }
    }











}