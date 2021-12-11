using System;
using Projeto_Final;

namespace CalcularRadiciacao
{
    class Radiciacao
    {
        public static void Racionalizar(){
            string _escolha = default;

            while(_escolha != "N"){
                Console.Clear();
                Console.WriteLine("========================    RADICIAÇÃO    =======================");

                Console.Write("Digite o radicando: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorA);

                Console.Write("\nDigite o índice: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorB);

                double _resultado = Math.Round(Math
                .Pow(_valorA,(1/_valorB)));

                Console.WriteLine($"\nResultado: Raiz elevada à ({_valorB})º potência de ({_valorA}) => {_resultado}");
                Console.Write("\nDeseja realizar o cálculo novamente [Y/N] ? ");

                _escolha = Console.ReadLine()
                .ToUpper();
            }
        }
    }
}