using System;
using Desafio1.Classes;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe denominada Elevador para armazenar as informações de um elevador
            // dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
            // no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
            // presentes nele. A classe deve também disponibilizar os seguintes métodos:
            // Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
            // andares no prédio (os elevadores sempre começam no térreo e vazio);

            // - Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
            // espaço);
            // - Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
            // dentro dele);
            // - Subir : para subir um andar (não deve subir se já estiver no último andar);
            // - Descer : para descer um andar (não deve descer se já estiver no térreo);
            // Encapsular todos os atributos da classe (criar os métodos set e get).

            Elevador elevador = new Elevador();

            Console.WriteLine("Digite o número do andar atual: ");
            elevador.andarAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de andares: ");
            elevador.totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade do elevador: ");
            elevador.capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de passageiros: ");
            elevador.NumPassageiros = int.Parse(Console.ReadLine());

            Console.WriteLine("Painel: ");
            Console.WriteLine("[0] - Inicializar elevador");
            Console.WriteLine("[1] - Adicionar passageiro");
            Console.WriteLine("[2] - Remover passageiro");
            Console.WriteLine("[3] - Subir um andar");
            Console.WriteLine("[4] - Descer um andar");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){
            case 0:
                Console.WriteLine($"Inicializando elevador com capacidade de: {elevador.capacidade} passageiros" +
                $" e {elevador.totalAndares} andares no prédio");
                break;
            case 1:
                Console.WriteLine($"Número atual de passageiros: {elevador.capacidade}");
                Console.WriteLine($"Passageiro adicionado. Agora temos {elevador.Entrar()} passageiros");
                break;
            case 2:
                Console.WriteLine($"Número atual de passageiros: {elevador.capacidade}");
                Console.WriteLine($"Passageiro removido. Agora temos {elevador.Sair()} passageiros");
                break;
            case 3: 
                Console.WriteLine($"Andar atual: {elevador.andarAtual}");
                Console.WriteLine($"Subir um andar: {elevador.Subir()}");
                break;
            case 4:
                Console.WriteLine($"Andar atual: {elevador.andarAtual}");
                Console.WriteLine($"Descer um andar: {elevador.Descer()}");
                break;
            }
        }
    }
}