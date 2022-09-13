using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Filme
    {
        public string nome;
        public int    ano;
        public double avaliacao;
        public bool   like;
        public string comentario;

        public Filme(string nome, int ano, double avaliacao, bool like, string comentario)
        {
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.like = like;
            this.comentario = comentario;
        }
    }
}
