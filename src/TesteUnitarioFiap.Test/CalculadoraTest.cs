using TesteUnitarioFiap.App;

namespace TesteUnitarioFiap.Test
{
    public class CalculadoraTest
    {
        private readonly Calculadora calculadora;
        public CalculadoraTest()
        {
            calculadora = new Calculadora();
        }

        [Fact]
        public void Somar_Deve_Retornar_Verdadeira_A_Soma()
        {
            var valorRecebidoSoma = calculadora.Somar(5, 2);

            var valorEsperadoSoma = 7;

            Assert.Equal(valorEsperadoSoma, valorRecebidoSoma);
        }

        [Fact]
        public void Subtrair_Deve_Retornar_Verdadeira_A_Subtracao()
        {
            var valorRecebidoSubtracao = calculadora.Subtrair(4, 1);

            var valorEsperadoSubtracao = 3;

            Assert.Equal(valorEsperadoSubtracao, valorRecebidoSubtracao);
        }

        [Fact]
        public void Multiplicar_Deve_Retornar_Verdadeira_A_Multiplicacao()
        {
            var valorRecebidoMultiplicacao = calculadora.Multiplicar(3, 2);

            var valorEsperadoMultiplicacao = 6;

            Assert.Equal(valorEsperadoMultiplicacao, valorRecebidoMultiplicacao);
        }

        [Fact]
        public void Dividir_Deve_Retornar_Verdadeira_A_Divisao()
        {
            var valorRecebidoDivisao = calculadora.Dividir(10, 2);

            var valorEsperadoDivisao = 5;

            Assert.Equal(valorEsperadoDivisao, valorRecebidoDivisao);
        }
    }
}