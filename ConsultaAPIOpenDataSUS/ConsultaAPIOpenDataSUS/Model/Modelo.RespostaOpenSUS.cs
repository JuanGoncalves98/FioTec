namespace ConsultaAPIOpenDataSUSService.Model
{
    public class RespostaOpenSUS
    {
        public RespostaOpenSUS()
        {
            this.hits = new RespostaOpenSUSHits();
        }

        public bool timed_out;
        public string _scroll_id;
        public RespostaOpenSUSHits hits;
    }
}
