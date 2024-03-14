namespace Calculadora_aula_do_andré
{
    public class Divisao : Operacao
    {
        public override double Calcular(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException("\nValor 2 não pode ser zero.\n\n\n");
            }

            return valor1 / valor2;
        }
    }
}
