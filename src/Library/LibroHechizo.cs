using System;
using System.Collections;
using System.Collections.Generic;
namespace Library 
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
    }
}