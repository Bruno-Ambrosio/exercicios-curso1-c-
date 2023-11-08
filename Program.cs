using System;

namespace ExerciciosCurso_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicios exercicios = new Exercicios();
            bool sair = false;
            String escolha = "";
            while (!sair)
            {
                Console.WriteLine("Escolha um exercício de 1 - 13\nEscolha 0 para sair");
                    escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        exercicios.Exercicio01();
                        break;
                    case "2":
                        exercicios.Exercicio02();
                        break;
                    case "3":
                        exercicios.Exercicio03();
                        break;
                    case "4":
                        exercicios.Exercicio04();
                        break;
                    case "5":
                        exercicios.Exercicio05();
                        break;
                    case "6":
                        exercicios.Exercicio06();
                        break;
                    case "7":
                        exercicios.Exercicio07();
                        break;
                    case "8":
                        exercicios.Exercicio08();
                        break;
                    case "9":
                        exercicios.Exercicio09();
                        break;
                    case "10":
                        exercicios.Exercicio10();
                        break;
                    case "11":
                        exercicios.Exercicio11();
                        break;
                    case "12":
                        exercicios.Exercicio12();
                        break;
                    case "13":
                        exercicios.Exercicio13();
                        break;
                }
            }
        }
    }
}