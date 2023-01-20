namespace ConsultaAPIOpenDataSUSService.Model
{
    public class RespostaOpenSUSHits
    {
        public RespostaOpenSUSHits() { }

        public string _index;
        public string _type;
        public RespostaOpenSUSTotal total;
        public RespostaOpenSUSHitsHits[] hits { get; set; }
    }
}
