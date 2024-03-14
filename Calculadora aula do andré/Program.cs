namespace Calculadora_aula_do_andré
{
    static class Program
    {
        static char opcao = char.MinValue;
        static double valor1, valor2;
        static void Main(string[] args)
        {

            while (!opcao.Equals('s'))
            {
                EntradaSaida.LimparTela();
                EntradaSaida.ImprimirLn(">>> Calculadora <<<");
                EntradaSaida.ImprimirLn("1 - Soma");
                EntradaSaida.ImprimirLn("2 - Subtração");
                EntradaSaida.ImprimirLn("3 - Divisão");
                EntradaSaida.ImprimirLn("4 - Multiplicação");
                EntradaSaida.ImprimirLn("s - Sair\n");
                EntradaSaida.Imprimir("Informe uma opção: ");
                opcao = EntradaSaida.LerOpcao(Console.ReadLine()!)[0];

                switch (opcao)
                {
                    case '1':

                        EntradaSaida.LimparTela();
                        InformeDeValores(out valor1, out valor2);
                        EntradaSaida.ImprimirLn($"\nSoma = {new Soma().Calcular(valor1, valor2)}\n");
                        EntradaSaida.Pausar();
                        break;

                    case '2':

                        EntradaSaida.LimparTela();
                        InformeDeValores(out valor1, out valor2);
                        EntradaSaida.ImprimirLn($"\nSubtração = {new Subtracao().Calcular(valor1, valor2)}\n");
                        EntradaSaida.Pausar();
                        break;

                    case '3':

                        EntradaSaida.LimparTela();
                        InformeDeValores(out valor1, out valor2);
                        EntradaSaida.ImprimirLn($"\nDivisão = {new Divisao().Calcular(valor1, valor2)}\n");
                        EntradaSaida.Pausar();
                        break;

                    case '4':

                        EntradaSaida.LimparTela();
                        InformeDeValores(out valor1, out valor2);
                        EntradaSaida.ImprimirLn($"\nMultiplicação = {new Multiplicacao().Calcular(valor1, valor2)}\n");
                        EntradaSaida.Pausar();
                        break;

                    case 's':

                        EntradaSaida.LimparTela();
                        EntradaSaida.ImprimirLn("Encerrando a calculadora.");
                        EntradaSaida.Pausar();
                        break;

                    default:

                        EntradaSaida.LimparTela();
                        EntradaSaida.ImprimirLn("Opção não implementada.");
                        EntradaSaida.Pausar();
                        break;

                }
            }

        }

        private static void InformeDeValores(out double valor1, out double valor2)
        {
            EntradaSaida.Imprimir("Informe o primeiro valor: ");
            valor1 = EntradaSaida.LerDoTeclado(Console.ReadLine()!);
            EntradaSaida.Imprimir("Informe o segundo valor: ");
            valor2 = EntradaSaida.LerDoTeclado(Console.ReadLine()!);
        }
    }
}