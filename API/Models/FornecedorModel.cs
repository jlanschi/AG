namespace Autoglass.API.Models
{
    public class FornecedorModel
    {
        public int Id { get; protected set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public string Tipo { get; set; }

        public int Situacao { get; protected set; }

    }
}
