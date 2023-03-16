using PPT;

namespace PPT_Test {
    public class UnitTest1 {
        // CASO EMPATE
        [Fact]
        public void Empate()
        {
            var piedra1 = new Piedra();
            var piedra2 = new Piedra();
            var resultado = piedra1.GanaContra(piedra2);
            Assert.Equal("Empate!",resultado);
        }
        // CASO PIERDE C/U
        [Fact] 
        public void PierdeTijera() { 
            var piedra = new Piedra();
            var tijera = new Tijera();
            var resultado = tijera.GanaContra(piedra);
            Assert.Equal("Pierde!", resultado);
        }
        [Fact]
        public void PierdePapel()
        {
            var tijera = new Tijera();
            var papel = new Papel();
            var resultado = papel.GanaContra(tijera);
            Assert.Equal("Pierde!", resultado);
        }
        [Fact]
        public void PierdePiedra()
        {
            var piedra = new Piedra();
            var papel = new Papel();
            var resultado = piedra.GanaContra(papel);
            Assert.Equal("Pierde!", resultado);
        }
        // CASO GANA C/U
        [Fact]
        public void GanaPiedra()
        {
            var piedra = new Piedra();
            var tijera = new Tijera();
            var resultado = piedra.GanaContra(tijera);
            Assert.Equal("Gano!", resultado);
        }
        [Fact]
        public void GanaTijera()
        {
            var tijera = new Tijera();
            var papel = new Papel();
            var resultado = tijera.GanaContra(papel);
            Assert.Equal("Gano!", resultado);
        }
        [Fact]
        public void GanaPapel()
        {
            var piedra = new Piedra();
            var papel = new Papel();
            var resultado = papel.GanaContra(piedra);
            Assert.Equal("Gano!", resultado);
        }

    }
}