using System;

namespace LibraryClass
{
    
    public class Ataque
    {
        /// <summary>
        /// Este método hace que se le quiten los puntos de vida del personaje2, con los puntos de ataque del personaje1. 
        /// </summary>
        /// <param name="personaje1"></param>
        /// <param name="personaje2"></param>
        public static void AtaqueFisico(Elfo personaje1, Enano personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

         public static void AtaqueFisico(Elfo personaje1, Gigante personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

         public static void AtaqueFisico(Elfo personaje1, Mago personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

         public static void AtaqueFisico(Enano personaje1, Elfo personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }
        public static void AtaqueFisico(Enano personaje1, Gigante personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }
        
        public static void AtaqueFisico(Enano personaje1, Mago personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }
        public static void AtaqueFisico(Mago personaje1, Enano personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

        public static void AtaqueFisico(Mago personaje1, Elfo personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }
        public static void AtaqueFisico(Mago personaje1, Gigante personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

        public static void AtaqueFisico(Gigante personaje1, Enano personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

        public static void AtaqueFisico(Gigante personaje1, Elfo personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

        public static void AtaqueFisico(Gigante personaje1, Mago personaje2)
        {
            personaje2.Estadisticas.PuntosDeVida -= personaje1.Estadisticas.Ataque;
            Console.WriteLine($"{personaje1.Nombre} atacó a {personaje2.Nombre}.");
        }

    }

    
}