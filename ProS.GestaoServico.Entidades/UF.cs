using System;
using System.Collections.Generic;
using System.Text;

namespace ProS.GestaoServico.Entidades
{
    public class UF
    {
        public int IdUF { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
