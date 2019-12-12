using System.Collections.Generic;

namespace ProS.GestaoServico.Entidades
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public int IdUF { get; set; }
        public string Nome { get; set; }
        public string CodigoIBGE { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
