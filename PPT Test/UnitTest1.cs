using PPT;
using Xunit.Abstractions;

namespace PPT_Test {
    public class XUnitTestClass {
        // https://www.jetbrains.com/help/resharper/Xunit.XunitTestWithConsoleOutput.html
        private readonly ITestOutputHelper _testOutputHelper;
        public XUnitTestClass(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        // ----------------------------
        // CASO EMPATE ----------------------------
        [Fact]
        public void EmpatePiedra()
        {
            var a = new Piedra();
            var b = new Piedra();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " empato contra " + b.Tipo,resultado);
        }
        [Fact]
        public void EmpateTijera()
        {
            var a = new Tijera();
            var b = new Tijera();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " empato contra " + b.Tipo, resultado);
        }
        [Fact]
        public void EmpatePapel()
        {
            var a = new Papel();
            var b = new Papel();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " empato contra " + b.Tipo, resultado);
        }
        // CASO PIERDE C/U ----------------------------
        [Fact] 
        public void PierdeTijera() {
            var a = new Tijera();
            var b = new Piedra();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " perdio contra " + b.Tipo, resultado);
        }
        [Fact]
        public void PierdePapel()
        {
            var a = new Papel();
            var b = new Tijera();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " perdio contra " + b.Tipo, resultado);
        }
        [Fact]
        public void PierdePiedra()
        {
            var a = new Piedra();
            var b = new Papel();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " perdio contra " + b.Tipo, resultado);
        }
        // CASO GANA C/U ----------------------------
        [Fact]
        public void GanaPiedra()
        {
            var a = new Piedra();
            var b = new Tijera();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " gano contra " + b.Tipo, resultado);
        }
        [Fact]
        public void GanaTijera()
        {
            var a = new Tijera();
            var b = new Papel();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " gano contra " + b.Tipo, resultado);
        }
        [Fact]
        public void GanaPapel()
        {
            var a = new Papel();
            var b = new Piedra();
            var resultado = a.GanaContra(b);
            _testOutputHelper.WriteLine(resultado);
            Assert.Equal(a.Tipo + " gano contra " + b.Tipo, resultado);
        }

    }
}