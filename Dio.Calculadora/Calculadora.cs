namespace Dio.Calculadora
{
    public class Calculadora(string data)
    {
        private readonly List<string> historicoLista = new List<string>();
        private readonly string data = data;

        /// <summary>
        /// Efetuar operação de adição de 2 números.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public int Somar(int val1, int val2) 
        {
            int resultadoSoma = val1 + val2;

            historicoLista.Insert(0, GeraHistorico(resultadoSoma, data));

            return resultadoSoma;
        }

        /// <summary>
        /// Efetua operação de subtração de 2 números.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public int Subtrair(int val1, int val2)
        {
            int resultadoSubtracao = val1 - val2;

            historicoLista.Insert(0, GeraHistorico(resultadoSubtracao, data));

            return resultadoSubtracao;
        }

        /// <summary>
        /// Efetua operação de multiplicação de 2 números
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public int Multiplicar(int val1, int val2)
        {
            int resultadoMult = val1 * val2;

            historicoLista.Insert(0, GeraHistorico(resultadoMult, data));

            return resultadoMult;
        }

        /// <summary>
        /// Efetua operação de Divisão de 2 números.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public int Dividir(int val1, int val2)
        {
            int resultadoDiv = val1 / val2;

            historicoLista.Insert(0, GeraHistorico(resultadoDiv ,data));

            return resultadoDiv;
        }

        /// <summary>
        /// Armazena histórico dos ultimos 3 calculos.
        /// </summary>
        /// <returns></returns>
        public List<string> Historico() 
        {
            historicoLista.RemoveRange(3, historicoLista.Count - 3);
            return historicoLista;
        }

        /// <summary>
        /// Gera mensagem do histórico de calculo.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private string GeraHistorico(int valor, string data)
        {
            return "Res: " + valor + " - data: " + data;
        }
    }
}
