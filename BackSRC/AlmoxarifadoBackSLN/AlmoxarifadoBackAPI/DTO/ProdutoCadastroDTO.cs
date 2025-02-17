namespace AlmoxarifadoBackAPI.DTO
{
    public class ProdutoCadastroDTO
    {
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public float EstoqueAtual { get; set; }
        public bool Epermanente { get; set; }
        public int CodigoCategoria { get; set; }
    }
}
