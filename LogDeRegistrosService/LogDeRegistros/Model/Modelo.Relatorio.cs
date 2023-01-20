namespace LogDeRegistros.Model
{
    public class Relatorio
    {
        public Relatorio() { }

        public Solicitante solicitante { get; set; }
        public DateTime dataSolicitacao { get; set; }
        public String descricaoRelatorio { get; set; }
        public DateTime dataAplicacao { get; set; }
        public int quantidadeDeVacinados { get; set; }
    }
}