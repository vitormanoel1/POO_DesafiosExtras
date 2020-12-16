using System;

namespace Desafio2.Classes
{
    public class JogadorFutebol
    {
        public string nome;
        public string posicao;
        public int dataNasci;
        public string nacionalidade;
        public float altura;
        public float peso;
        public int anoAtual;
        public int Idade()
        {
            return  anoAtual - dataNasci;
        }
        
    }
}