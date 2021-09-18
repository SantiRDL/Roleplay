using NUnit.Framework;
using LibraryClass;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void AtaqueMagicoTest()
        {
            Elfo elfo = new Elfo("elfo");
            Mago mago = new Mago("mago");
            Ataque.AtaqueMagico(elfo,mago);
            Assert.AreEqual(mago.Estadisticas.PuntosDeVida,20);
        }
    }


}