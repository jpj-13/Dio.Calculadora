using Dio.Calculadora;
using System;
using Xunit;

namespace TestDio.Calculadora
{
    public class CalculadoraTest
    {
        Dio.Calculadora.Calculadora calc;

        public CalculadoraTest()
        {
            calc = ConstruirClasse();
        }


        private Dio.Calculadora.Calculadora ConstruirClasse()
        {
            string data = "27/04/2024";
            Dio.Calculadora.Calculadora calc = new Dio.Calculadora.Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 5, 6)]
        public void DeveAdicionar2Numeros(int val1, int val2, int resultado)  
        {
            //Arrange
            calc = ConstruirClasse();

            //Act
            int resultadoCalculadora = calc.Somar(val1, val2);

            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(5, 3, 2)]
        public void DeveSubtrair2Numeros(int val1, int val2, int resultado)
        {
            calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(7, 5, 35)]
        public void DeveMultiplicar2Numeros(int val1, int val2, int resultado)
        {
            calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(6, 2, 3)]
        public void DeveDividir2Numeros(int val1, int val2, int resultado)
        {
            calc = ConstruirClasse();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void NaoDeveDividirPorZero()
        {
            calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void DeveGerarHistoricoDeAdicaode2Numeros()
        {
            calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(1, 5);
            calc.Somar(7, 2);
            calc.Somar(8, 3);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}