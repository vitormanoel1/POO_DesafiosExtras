using System;
using Desafio2.Classes;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe para representar um jogador de futebol, com os atributos nome, posição,
            // data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos 
            // os dados do jogador. Crie um método para calcular a idade do jogador e outro método para 
            // mostrar quanto tempo falta para o jogador se aposentar. Para isso, considere que os
            // jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo 
            // aos 38 e os atacantes aos 35.

            JogadorFutebol jogador = new JogadorFutebol();
            
            Console.WriteLine("dgite sua posição: Atacante Meio, Defesa ");
            jogador.posicao = Console.ReadLine();

            Console.WriteLine("digite seu nome: ");
            jogador.nome = Console.ReadLine();

            Console.WriteLine("digite sua nacionalidade: ");
            jogador.nacionalidade = Console.ReadLine();

            Console.WriteLine("digite sua altura: ");
            jogador.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("digite seu peso: ");
            jogador.peso = float.Parse(Console.ReadLine());

            Console.WriteLine("digite data atual: ");
            jogador.anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("digite sua data de nascimento: ");
            jogador.dataNasci = int.Parse(Console.ReadLine());


             if(jogador.posicao == "Defesa") 
             {
                if(jogador.Idade() >= 40) 
                {
                    Console.WriteLine("Você já pode se aposentar");
                } 
                else
                {
                    Console.WriteLine($"falta {40 - jogador.Idade()} anos para você poder se aposentar");
                }
            } 
            else if(jogador.posicao == "Meio") 
            {
                if(jogador.Idade() >= 38) {
                    Console.WriteLine("Você já pode se aposentar");
                } 
                else
                {
                    Console.WriteLine($"falta {38 - jogador.Idade()} anos para você poder se aposentar");
                }
            } 
            else if(jogador.posicao == "Atacante") 
            {
                if(jogador.Idade() >= 35) 
                {
                    Console.WriteLine("Você já pode se aposentar");
                } 
                else 
                {
                    Console.WriteLine($"falta {35 - jogador.Idade()} anos para você poder se aposentar");
                }
            }
        }
    }
}