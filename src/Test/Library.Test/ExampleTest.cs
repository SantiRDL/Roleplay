using NUnit.Framework;
using LibraryClass;


namespace Test.Library
{


    public class ExampleTest
    {
        /// <summary>
        /// Este test comprobara si el enano efectivamente ataca al gigante
        /// </summary>
        [Test]
        public void AtaqueFisicoTest()
        {
            Enano enano = new Enano("enano");
            Gigante gigante = new Gigante("gigante");
            Ataque.AtaqueFisico(enano, gigante);
            Assert.AreEqual(gigante.Estadisticas.PuntosDeVida,10);
        }
    }
}