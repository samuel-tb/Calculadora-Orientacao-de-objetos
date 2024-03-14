namespace Calculadora_aula_do_andré
{
    public class Soma : Operacao
    {

        public override double Calcular(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public override string ToString()
        {
            return "Exemplo";
        }

    }
}
