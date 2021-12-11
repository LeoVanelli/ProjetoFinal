using System;
using Projeto_Final;

namespace CalcularAdicao
{
    class Adicao
    {
        public static void Somar(){
            string _escolha = default;

            while(_escolha != "N"){
                Console.Clear();
                Console.WriteLine("========================    ADIÇÃO    =======================");

                Console.Write("Digite o primeiro valor: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorA);

                Console.Write("\nDigite o segundo valor: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorB);

                double _resultado = Convert.ToDouble(_valorA + _valorB);

                Console.WriteLine($"\nResultado: {_valorA} + {_valorB} = {_resultado}");
                Console.Write("\nDeseja realizar o cálculo novamente [Y/N] ? ");

                _escolha = Console.ReadLine().ToUpper();
            }
        }
    }
}