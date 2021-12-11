using System;
using Projeto_Final;

namespace CalcularDivisao
{
    class Divisao
    {
        public static void Dividir(){
            string _escolha = default;

            while(_escolha != "N"){
                Console.Clear();
                Console.WriteLine("========================    DIVISÃO    =======================");

                Console.Write("Digite o primeiro valor: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorA);

                Console.Write("\nDigite o segundo valor: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out double _valorB);

                if(_valorA != 0 && _valorB != 0){
                    double _resultado = Convert.ToDouble(_valorA / _valorB);

                    Console.WriteLine($"\nResultado: {_valorA} / {_valorB} = {_resultado}");
                    Console.Write("\nDeseja realizar o cálculo novamente [Y/N] ? ");

                    _escolha = Console.ReadLine().ToUpper();
                }
                else{
                    Console.Write("\nNão é possível dividir por 0 !!!\n\nPressione qualquer tecla para reiniciar o cálculo. . .");

                    Console.ReadKey();
                }
            }
        }
    }
}