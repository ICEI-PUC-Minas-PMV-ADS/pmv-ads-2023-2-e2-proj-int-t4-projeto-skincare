public class PerguntaResposta
{
    public int Id { get; set; }
    public string Pergunta { get; set; }
    public List<string> Respostas { get; set; }
    public string RespostaSelecionada { get; set; }

    public PerguntaResposta(int id, string pergunta, List<string> respostas)
    {
        Id = id;
        Pergunta = pergunta;
        Respostas = respostas;
        RespostaSelecionada = null; 
    }
}
