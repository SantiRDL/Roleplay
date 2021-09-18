using System;

namespace LibraryClass
{
     public class Estadistica
    {
        public Estadistica(int puntosDeVida, int ataque, int magia, int defensa, int defensaMagica)
        {
            this.PuntosDeVida = puntosDeVida;
            this.Ataque = ataque;
            this.Magia = magia;
            this.Defensa = Defensa;
            this.DefensaMagica = defensaMagica;
        }

        public int PuntosDeVida { get; set; }
        public int Ataque { get; set; }
        public int Magia { get; set; }
        public int Defensa { get; set; }
        public int DefensaMagica { get; set; }

    }
}