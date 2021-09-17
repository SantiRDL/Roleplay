using System;

namespace LibraryClass
{
    class Mago
    {
        public string Nombre;
        public Estadistica Estadisticas = new Estadistica;
        Estadisticas.Ataque = 10;
        Estadisticas.PuntosDeVida = 70;
        Estadisticas.Magia = 90;
        Estadisticas.Defensa = 20;
        Estadisticas.DefensaMagica = 30;
        public Equipamiento Objeto = null;
        public LibroHechizos LibroDeHechizos = null;

        public Mago(string nombre)
        {
            this.Nombre = nombre;
            
        }

        
        

        /// <summary>
        /// Reducen los puntos de vida del personaje atacado en base a las estadisticas de ataque.
        /// Hay 3 metodos distintos de ataque, uno para cada tipo de personaje, el programa ejecuta uno u otro en base al parametro que se introduzca.
        /// </summary>
        /// <param name="personajeAtacado"></param>
        public void AtaqueFisico(Gigante personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
        public void AtaqueFisico(Enano personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
        }
        public void AtaqueFisico(Elfo personajeAtacado)
        {
            personajeAtacado.Estadisticas.PuntosDeVida = personajeAtacado.Estadisticas.PuntosDeVida - this.Estadisticas.Ataque;
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
        /// Toma un objeto de tipo equipamiento como parametro, lo coloca en el atributo Objeto y suma sus estadisticas a las estdisticas del personaje.
        /// </summary>
        /// <param name="objeto"></param>
        public void EquiparObjeto(Equipamiento objeto)
        {
            this.Objeto = objeto;
            this.Estadisticas.Ataque += objeto.Estadisticas.Ataque;
            this.Estadisticas.PuntosDeVida += objeto.Estadisticas.PuntosDeVida;
            this.Estadisticas.Magia += objeto.Estadisticas.Magia;
            this.Estadisticas.Defensa += objeto.Estadisticas.Defensa;
            this.Estadisticas.DefensaMagica += objeto.Estadisticas.DefensaMagica;
            

        }
        /// <summary>
        /// Toma un objeto ya equipado como parametro, lo quita del atributo Objeto y suma sus estadisticas a las estadisticas del personaje.
        /// </summary>
        /// <param name="objeto"></param>
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
        /// <summary>
        /// Toma un objeto de tipo libro y, en caso de que no haya ningun libro equipado, lo equipa en el atributo LibroDeHechizos.
        /// </summary>
        /// <param name="libro"></param>
        public void EquiparLibro(Libro libro)
        {
            if (this.LibroDeHechizos = null)
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
        public void DesequiparLibro(Libro LibroHechizos)
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
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.AtaqueHechizo;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.NombreHechizo} causando {this.LibroDeHechizos.AtaqueHechizo} de daño");
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
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.AtaqueHechizo;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.NombreHechizo} causando {this.LibroDeHechizos.AtaqueHechizo} de daño");
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
                personajeAtacado.Estadisticas.PuntosDeVida -= this.LibroDeHechizos.AtaqueHechizo;
                Console.WriteLine($"El Mago {this.Nombre} lanza el hechizo {this.LibroDeHechizos.NombreHechizo} causando {this.LibroDeHechizos.AtaqueHechizo} de daño");
            }
            else
            {
                Console.WriteLine("No hay un libro de hechizos equipado.");
            }
        }
    }
}