using System;

namespace LibraryClass
{
    public class Mago
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica(70, 10, 90, 20, 30);
        
        public Equipamiento Objeto = null;
        public LibroHechizos LibroDeHechizos = null;

        public Mago(string nombre)
        {
            this.Nombre = nombre;   
        }
        /// <summary>
        /// Reducen los puntos de vida del personaje atacado en base a la estadistica AtaqueHechizo del Libro de hechizos.
        /// Hay 3 metodos distintos de LanzarHechizo, uno para cada tipo de personaje, el programa ejecuta uno u otro en base al parametro que se introduzca.
        /// </summary>
        /// <param name="personajeAtacado"></param>
        public void LanzarHechizo(Gigante personajeAtacado)
        {
            if (this.LibroDeHechizos != null)
            {
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.Ataque;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.Nombre} causando {this.LibroDeHechizos.Ataque} de daño");
            }
            else
            {
                Console.WriteLine("No hay un libro de hechizos equipado.");
            }
        }

        public void LanzarHechizo(Enano personajeAtacado)
        {
            if (this.LibroDeHechizos != null)
            {
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.Ataque;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.Nombre} causando {this.LibroDeHechizos.Ataque} de daño");
            }
            else
            {
                Console.WriteLine("No hay un libro de hechizos equipado.");
            }
        }
        public void LanzarHechizo(Elfo personajeAtacado)
        {
            if (this.LibroDeHechizos != null)
            {
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.Ataque;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.Nombre} causando {this.LibroDeHechizos.Ataque} de daño");
            }
            else
            {
                Console.WriteLine("No hay un libro de hechizos equipado.");
            }
        }
        public int ObtenerAtaque()
        {
            return this.Estadisticas.Ataque;
        }
    }
}