using System;

namespace Desafio1.Classes
{
        public class Elevador
    {
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int numPassageiros;
        public int NumPassageiros
        {
            get;set;
        }
        public int Entrar()
        {
            return capacidade += 1;
        }
        public int Sair()
        {
            return capacidade -= 1;
        }
        public int Subir()
        {
            if(andarAtual >= totalAndares)
            {
                Console.WriteLine("Não é possível subir, já estamos no ultimo andar!");
            } 
            return andarAtual += 1;
        }
        public int Descer()
        {
            if(andarAtual <= 0) 
            {
                Console.WriteLine("Não é possível descer estamos no térreo!");
            }
            return andarAtual -= 1;
        }
    }
}