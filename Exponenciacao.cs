using System;
using Projeto_Final;

namespace CalcularExponenciacao
{
    class Exponenciacao
    {
        public static void Exponenciar(){
            string _escolha = default;

            while(_escolha != "N"){
                Console.Clear();
                Console.WriteLine("========================    EXPONENCIAÇÃO    =======================");

                Console.Write("Digite a base: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorA);

                Console.Write("\nDigite o expoente: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorB);

                double _resultado = Math.Round(Math
                .Pow(_valorA,_valorB));

                Console.WriteLine($"\nResultado: ({_valorA}) elevado(a) à ({_valorB}) = {_resultado}");
                Console.Write("\nDeseja realizar o cálculo novamente [Y/N] ? ");

                _escolha = Console.ReadLine()
                .ToUpper();
            }
        }
    }
}