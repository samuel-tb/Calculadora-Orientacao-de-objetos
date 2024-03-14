

namespace Calculadora_aula_do_andré
{
    public static class EntradaSaida
    {
        public static void Imprimir(string conteudo)
        {
            Console.Write(conteudo);
        }

        public static void ImprimirLn(string conteudo)
        {
            Console.WriteLine(conteudo);
        }

        public static void LimparTela()
        {
            Console.Clear();
        }

        public static string LerOpcao(string opcao)
        {
            return opcao;
        }

        public static void Pausar()
        {
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
            
        }

        public static double LerDoTeclado(string conteudo)
        {
            return double.Parse(conteudo);
        }


    }
}
