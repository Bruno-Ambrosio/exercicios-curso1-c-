using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExerciciosCurso_1
{
    internal class Exercicios
    {
        public void Exercicio01()
        {
            for (int i = 1000; i > 0; i--)
            {
                Console.WriteLine(i + " ");
            }
        }
        public void Exercicio02()
        {

            try
            {
                Console.WriteLine("Digite a quantidade de números:");
                short quantidade = short.Parse(Console.ReadLine());
                int[] numeros = new int[quantidade];
                int soma = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digite o número da posição: " + i);
                    numeros[i] = int.Parse(Console.ReadLine());
                    soma += numeros[i];

                }
                Console.WriteLine("A média aritmética deles é de: " + (soma / quantidade));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Exercicio03()
        {
            for (int i = 0; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    continue;
                }
            }
        }
        public void Exercicio04()
        {
            Console.WriteLine("Insira um número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(String.Format("{0} x {1} = {2}", numero, i, numero * i));
            }

        }
        public void Exercicio05()
        {
            int[] numeros = new int[4];
            Console.WriteLine("Informe 4 números");
            for (int i = 0; i < 4; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int somaPar = 0;
            int somaImpar = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    somaPar += numero;
                }
                else
                {
                    somaImpar += numero;
                }
            }
            Console.WriteLine(String.Format("Soma dos números pares: {0} \n Soma dos números ímpares: {1}", somaPar, somaImpar));
        }
        public void Exercicio06()
        {
            bool sair = false;
            String nome;
            double somaNotas = 0;
            List<double> notas = new List<double>();
            Dictionary<String, List<double>> grade = new Dictionary<String, List<double>>();
            while (!sair)
            {
                Console.WriteLine("Digite o nome do aluno:");
                nome = Console.ReadLine();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(String.Format("Digite a nota {0} do aluno {1}", i, nome));
                    notas.Add(double.Parse(Console.ReadLine()));
                }
                grade.Add(nome, notas);
                Console.WriteLine("Deseja informar notas de mais algum aluno? s/n");
                String resposta = Console.ReadLine();
                if (resposta.Trim().ToLower().Equals("n"))
                {
                    sair = true;
                }
            }
            foreach (string aluno in grade.Keys)
            {
                Console.Write(String.Format("Notas do aluno {0}: ", aluno));
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(grade[aluno][i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Média do aluno {0}: {1}", aluno, grade[aluno].Sum() / 4);
            }
        }
        public void Exercicio07()
        {
            List<int> numeros = new List<int>();
            String informado = "";
            int anterior = 0;
            bool sair = false;
            Console.WriteLine("Informe quantos números quiser");
            while (!sair)
            {
                informado = Console.ReadLine();
                if (informado == "s")
                {
                    sair = true;
                }
                else
                {
                    try
                    {
                        numeros.Add(int.Parse(informado));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor informado inválido");
                    }
                }
                foreach (int numero in numeros)
                {
                    if (numero >= anterior)
                    {
                        anterior = numero;
                    }
                }
            }
            Console.WriteLine(String.Format("O maior número é {0}", anterior));
        }
        public void Exercicio08()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(String.Format("Número múltiplo de 3: {0}", i));
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Exercicio09()
        {
            String opcao = "";
            bool sair = false;
            double[] numeros = new double[2];
            List<double> resultados = new List<double>();
            while (!sair)
            {
                Console.WriteLine("Escolha uma opção: \n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\ns - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Insira dois números");
                        numeros[0] = (double.Parse(Console.ReadLine()));
                        numeros[1] = (double.Parse(Console.ReadLine()));
                        resultados.Add(numeros[0] + numeros[1]);
                        break;
                    case "2":
                        Console.WriteLine("Insira dois números");
                        numeros[0] = (double.Parse(Console.ReadLine()));
                        numeros[1] = (double.Parse(Console.ReadLine()));
                        resultados.Add(numeros[0] - numeros[1]);
                        break;
                    case "3":
                        Console.WriteLine("Insira dois números");
                        numeros[0] = (double.Parse(Console.ReadLine()));
                        numeros[1] = (double.Parse(Console.ReadLine()));
                        resultados.Add(numeros[0] * numeros[1]);
                        break;
                    case "4":
                        Console.WriteLine("Insira dois números");
                        numeros[0] = (double.Parse(Console.ReadLine()));
                        numeros[1] = (double.Parse(Console.ReadLine()));
                        resultados.Add(numeros[0] / numeros[1]);
                        break;
                    case "s":
                        sair = true;
                        break;
                    case "S":
                        sair = true;
                        break;
                }
            }
            Console.WriteLine("Resultados: ");
            foreach (double resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
        public void Exercicio10()
        {
            double salario = 1;
            bool sair = false;
            Console.WriteLine("Informe um salário ou 0 para sair");
            salario = Double.Parse(Console.ReadLine());
            if (salario != 0)
            {
                if (salario <= 1903.98)
                {
                    Console.WriteLine("Não tem imposto salario final = " + salario);
                }
                else if (salario <= 2826.65)
                {
                    salario = (salario * 0.925) - 142.80;
                }
                else if (salario <= 3751.05)
                {
                    salario = (salario * 0.85) - 354.80;
                }
                else if (salario <= 4664.68)
                {
                    salario = (salario * 0.775) - 636.13;
                }
                else if (salario > 4664.68)
                {
                    salario = (salario * 0.725) - 869.36;
                }
            }
            Console.WriteLine("Salario com imposto: " + salario);

        }
        public void Exercicio11()
        {
            Dictionary<String, int> nadadores = new Dictionary<String, int>();
            bool sair = false;
            String nome = "";
            int idade = 0;
            while (!sair)
            {
                Console.WriteLine("Insira um nadador ou 0 para sair:");
                nome = Console.ReadLine();
                if (nome.Equals("0"))
                {
                    sair = true;
                }
                else
                {
                    Console.WriteLine("Insira uma idade:");
                    idade = int.Parse(Console.ReadLine());
                    nadadores[nome] = idade;
                }
            }
            foreach (String nadador in nadadores.Keys)
            {
                if (nadadores[nadador] >= 5 && nadadores[nadador] <= 7)
                {
                    Console.WriteLine(String.Format("o nadador: {0}, tem {1} anos e está classificado como {2}", nadador, nadadores[nadador], "Infantil A"));
                }
                else if (nadadores[nadador] >= 8 && nadadores[nadador] <= 11)
                {
                    Console.WriteLine(String.Format("o nadador: {0}, tem {1} anos e está classificado como {2}", nadador, nadadores[nadador], "Infantil B"));
                }
                else if (nadadores[nadador] >= 12 && nadadores[nadador] <= 13)
                {
                    Console.WriteLine(String.Format("o nadador: {0}, tem {1} anos e está classificado como {2}", nadador, nadadores[nadador], "Juvenil A"));
                }
                else if (nadadores[nadador] >= 14 && nadadores[nadador] <= 17)
                {
                    Console.WriteLine(String.Format("o nadador: {0}, tem {1} anos e está classificado como {2}", nadador, nadadores[nadador], "Juvenil B"));
                }
                else if (nadadores[nadador] >= 18)
                {
                    Console.WriteLine(String.Format("o nadador: {0}, tem {1} anos e está classificado como {2}", nadador, nadadores[nadador], "Adultos"));
                }
            }
        }
        public void Exercicio12()
        {
            bool sair = false;
            List<double> numeros = new List<double>();
            double numero;
            double numeroMaior = 0;
            while (!sair)
            {
                Console.WriteLine("Insira vários numeros e 0 para finalizar");
                numero = double.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    numeros.Add(numero);
                }
                else
                {
                    sair = true;
                }
            }
            foreach (double num in numeros)
            {
                if (num > numeroMaior)
                {
                    numeroMaior = num;
                }
            }
            Console.WriteLine(String.Format("O número maior é {0}", numeroMaior));
        }
        public void Exercicio13()
        {
            Console.Write("Informe a quantidade de anos de trabalho: ");
            int anosTrabalhados = int.Parse(Console.ReadLine());

            Console.Write("Informe o salário inicial: ");
            double salarioInicial = double.Parse(Console.ReadLine());

            double salarioAtual = salarioInicial;

            for (int ano = 1; ano <= anosTrabalhados; ano++)
            {
                if (ano <= 3)
                {
                    salarioAtual += salarioAtual * 0.5;
                }
                else if (ano % 10 == 0)
                {
                    salarioAtual += salarioAtual * 0.1;
                }
                else
                {
                    salarioAtual += salarioAtual;
                }
            }

            Console.WriteLine(String.Format("Salário após {0} anos de trabalho: R$ {1}", anosTrabalhados, salarioAtual));
        }
    }
}

