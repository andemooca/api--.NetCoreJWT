namespace ProS.GestaoServico.Entidades
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public int IdMunicipio { get; set; }
        public Municipio Municipio { get; set; }
        public int IdUF { get; set; }
        public UF UF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
    }
}
