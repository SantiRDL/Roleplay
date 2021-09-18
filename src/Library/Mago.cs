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
        /// Reducen los puntos de vida del personaje atacado en base a la estadistica magia.
        /// Hay 3 metodos distintos de ataque magico, uno para cada tipo de personaje, el programa ejecuta uno u otro en base al parametro que se introduzca.
        /// </summary>
        /// <param name="personajeAtacado"></param>
        public void AtaqueMagico(Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Magia;
        }
        public void AtaqueMagico(Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Magia;
        }
        public void AtaqueMagico(Elfo personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Magia;
        }
                
        /// <summary>
        /// Toma un objeto de tipo libro y, en caso de que no haya ningun libro equipado, lo equipa en el atributo LibroDeHechizos.
        /// </summary>
        /// <param name="libro"></param>
        public void EquiparLibro(LibroHechizos libro)
        {
            if (this.LibroDeHechizos == null)
            {
                this.LibroDeHechizos = libro;
            }
            else
            {
                Console.WriteLine("Ya hay un libro de hechizos equipado");
            }
        }
        /// <summary>
        /// Desequipa el libro de Hechizos.
        /// </summary>
        /// <param name="libro"></param>
        public void DesequiparLibro(LibroHechizos LibroHechizos)
        {
            this.LibroDeHechizos = null;
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