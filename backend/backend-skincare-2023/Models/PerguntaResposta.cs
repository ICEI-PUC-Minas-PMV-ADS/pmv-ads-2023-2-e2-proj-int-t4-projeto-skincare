namespace backend_skincare_2023.Models
{
    public class PerguntaResposta
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public List<string> Respostas { get; set; }

        public PerguntaResposta(int id, string pergunta, List<string> respostas)
        {
            Id = id;
            Pergunta = pergunta;
            Respostas = respostas;
        }
    }
}
