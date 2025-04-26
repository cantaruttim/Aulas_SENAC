using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtnExcluir
{
    internal class Contato
    {
        public int id;
        public string nome;


        public Contato(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public Contato() { }

    }
}
