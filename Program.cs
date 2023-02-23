using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        
        enum Menu {Soma = 1, Subtração, Multiplicação, Divisão, RaizQuadrada, Potência, Sair}  
        

        static void Main(string[] args)
        {
            
            bool sair = false;
            float resultado = 0;

            while (!sair)
            {
                if (resultado != 0)
                {
                    Console.WriteLine("APERTE UMA TECLA PARA CONTINUAR OU APERTE ENTER PARA LIMPAR\n");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        resultado = 0;
                    }
                    else if (key.Key != ConsoleKey.Enter)
                    { Console.Clear();}
                }

                Console.WriteLine("Escolha sua operação!\n");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Raíz Quadrada\n6 - Potência\n7 - Sair\n");
                Console.WriteLine($"atual: {resultado}\n");
                Menu escolha = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");

                if (resultado == 0)
                {

                    switch (escolha)
                    {
                        case Menu.Soma:
                            Console.WriteLine("SOMA\n");
                            Console.WriteLine("Digite o primeiro valor");
                            float adi1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor");
                            float adi2 = float.Parse(Console.ReadLine());
                            resultado = adi1 + adi2;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Subtração:
                            Console.WriteLine("SUBTRAÇÃO\n");
                            Console.WriteLine("Digite o primeiro valor");
                            float sub1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor");
                            float sub2 = float.Parse(Console.ReadLine());
                            resultado = sub1 - sub2;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Multiplicação:
                            Console.WriteLine("MULTIPLICAÇÃO\n");
                            Console.WriteLine("Digite o primeiro valor");
                            float mult1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor");
                            float mult2 = float.Parse(Console.ReadLine());
                            resultado = mult1 * mult2;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Divisão:
                            Console.WriteLine ("DIVISÃO\n");
                            Console.WriteLine("Digite o primeiro valor");
                            float div1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor");
                            float div2 = float.Parse(Console.ReadLine());
                            resultado = div1 / div2;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.RaizQuadrada:
                            Console.WriteLine("RAÍZ QUADRADA\n");
                            Console.WriteLine("Digite a base");
                            float raiz1 = float.Parse(Console.ReadLine());
                            resultado = (float)Math.Sqrt(raiz1);
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Potência:
                            Console.WriteLine("POTÊNCIA\n");
                            Console.WriteLine("Digite a base");
                            float pot1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o expoente");
                            float pot2 = float.Parse(Console.ReadLine());
                            resultado = (float)Math.Pow(pot1,pot2);
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Sair:
                            sair = true;
                            break;

                        default:
                            Console.WriteLine("Opção Inválida");
                            Console.WriteLine("---------------------------");
                            break;
                    }
                }
                else
                {
                    
                    switch (escolha)
                    {
                        case Menu.Soma:
                            Console.WriteLine("SOMA\n");
                            Console.WriteLine("Digite o segundo valor");
                            float adi1 = float.Parse(Console.ReadLine());
                            resultado = resultado + adi1;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Subtração:
                            Console.WriteLine("SUBTRAÇÃO\n");
                            Console.WriteLine("Digite o segundo valor");
                            float sub1 = float.Parse(Console.ReadLine());
                            resultado = resultado - sub1;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Multiplicação:
                            Console.WriteLine("MULTIPLICAÇÃO\n");
                            Console.WriteLine("Digite o segundo valor");
                            float mult1 = float.Parse(Console.ReadLine());
                            resultado = resultado * mult1;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Divisão:
                            Console.WriteLine("DIVISÃO\n");
                            Console.WriteLine("Digite o segundo valor");
                            float div1 = float.Parse(Console.ReadLine());
                            resultado = resultado / div1;
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.RaizQuadrada:
                            Console.WriteLine("RAÍZ QUADRADA\n");
                            Console.WriteLine("Digite a base");
                            float raiz1 = float.Parse(Console.ReadLine());
                            resultado = (float)Math.Sqrt(raiz1);
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Potência:
                            Console.WriteLine("POTÊNCIA\n");
                            Console.WriteLine("Digite o expoente");
                            float pot2 = float.Parse(Console.ReadLine());
                            resultado = (float)Math.Pow(resultado, pot2);
                            Console.WriteLine($"\nO resultado é: {resultado}\n");
                            break;

                        case Menu.Sair:
                            sair = true;
                            break;

                        default:
                            Console.WriteLine("Opção Inválida");
                            Console.WriteLine("---------------------------");
                            break;

                    }

                }

            }
        }

        static void RaizQuadrada() 
        {




        }

        static void Potencia() 
        {
            



        }
    }
}
