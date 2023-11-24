using System;
//Ayrton

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("C A L C U L A D O R A");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Exit(); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            (float v1, float v2) = GetDataUser();

            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            GetBack();
        }

        static void Subtraction()
        {
            (float v1, float v2) = GetDataUser();

            Console.WriteLine($"O resultado da subtração é {v1 - v2}");
            GetBack();
        }

        static void Division()
        {
            (float v1, float v2) = GetDataUser();

            Console.WriteLine($"O resultado da divisão é {v1 / v2}");
            GetBack();
        }

        static void Multiplication()
        {
            (float v1, float v2) = GetDataUser();

            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
            GetBack();
        }

        static (float, float) GetDataUser()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            return (v1, v2);
        }

        static void GetBack()
        {
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Até mais!");
            Environment.Exit(0);
        }
    }
}
