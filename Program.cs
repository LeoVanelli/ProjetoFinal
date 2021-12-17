using System;
using CalcularSubtracao;
using CalcularAdicao;
using CalcularMultiplicacao;
using CalcularDivisao;
using CalcularRadiciacao;
using CalcularExponenciacao;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int _calculoSelecionado = default;

            while(_calculoSelecionado != 8)
            {
                Console.Clear();

                MontaMenu();

                Console.Write("Digite a seguir qual operação deverá ser realizada: ");
                
                int.TryParse(Console
                .ReadLine()
                .ToString(), out _calculoSelecionado);

                switch(_calculoSelecionado){

                    case 1:
                        Console.Clear();
                        Adicao Adic = new Adicao();
                        Adic.Somar();
                        break;
                    
                    case 2:
                        Console.Clear();
                        Subtracao.Subtrair();
                        break;

                    case 3:
                        Console.Clear();
                        Multiplicacao.Multiplicar();
                        break;

                    case 4:
                        Console.Clear();
                        Divisao.Dividir();
                        break;

                    case 5:
                        Console.Clear();
                        Exponenciacao.Exponenciar();
                        break;

                    case 6:
                        Console.Clear();
                        Radiciacao.Racionalizar();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("=========================    SOBRE MIM    ========================");
                        Console.WriteLine("||\t\t\t\t\t\t\t\t||");
                        Console.WriteLine("|| Desenvolvido com muito carinho por {Leandro Vanelli}\t\t||");
                        Console.WriteLine("|| Saiba mais em: https://leovanelli.github.io/ProjetoFinal/\t||");
                        Console.WriteLine("||\t\t\t\t\t\t\t\t||");
                        Console.WriteLine("==================================================================\n");

                        Console.WriteLine("Pressione qualquer tecla para continuar. . . ");
                        Console.ReadLine();
                        break;
                }
            }                       
        }

        static void MontaMenu(){
            Console.WriteLine("========================    CALCULADORA    =======================");
            Console.WriteLine("||\tBem vindo ao projeto final 'CALCULADORA' !\t\t||");
            Console.WriteLine("||\t1 - Somar\t\t\t\t\t\t||");
            Console.WriteLine("||\t2 - Subtrair\t\t\t\t\t\t||");
            Console.WriteLine("||\t3 - Multiplicação\t\t\t\t\t||");
            Console.WriteLine("||\t4 - Divisão\t\t\t\t\t\t||");
            Console.WriteLine("||\t5 - Exponenciação\t\t\t\t\t||");
            Console.WriteLine("||\t6 - Radiciação\t\t\t\t\t\t||");
            Console.WriteLine("||\t7 - Sobre\t\t\t\t\t\t||");
            Console.WriteLine("||\t8 - Sair\t\t\t\t\t\t||");
            Console.WriteLine("==================================================================\n");
        }
    }
}
