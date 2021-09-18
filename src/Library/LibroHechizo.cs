using System;
using System.Collections;
using System.Collections.Generic;
namespace LibraryClass
{
    public class LibroHechizos
    {
        public static List<LibroHechizos> lista = new List<LibroHechizos> ();

        public string Nombre {get; private set;}

        public int Ataque {get; private set;}

        public LibroHechizos (string alias,int agresion) 
        {
            this.Nombre = alias;
            this.Ataque = agresion;
            lista.Add(this);
        }

        public static LibroHechizos GetLibroHechizos (string nombre)
        {
            return lista.Find(match => match.Nombre == nombre.Trim());
        }
        public void EquiparLibro(LibroHechizos libro, Mago mago)
        {
            if (mago.LibroDeHechizos == null)
            {
                mago.LibroDeHechizos = libro;
            }
            else
            {
                Console.WriteLine("Ya hay un libro de hechizos equipado");
            }
        }
        public void DesequiparLibro(LibroHechizos LibroHechizos, Mago mago)
        {
            mago.LibroDeHechizos = null;
        }

    }
}