namespace backend_skincare_2023.Models
{
    public class Questionario
    {
        public List<PerguntaResposta> Perguntas { get; set; }


        public Questionario()
        {
            Perguntas = new List<PerguntaResposta>();
     
            Perguntas.Add(new PerguntaResposta("Como você descreveria a sua pele? ", new List<string> { "Pele Mista", "Pele oleosa", "Pele normal", "Pele seca" }));
            Perguntas.Add(new PerguntaResposta("Sua pele é sensível? Fica irritada ou vermelha com facilidade?", new List<string> { "Sim", "Não" }));
            Perguntas.Add(new PerguntaResposta("Possui alguma lesão ou problema de pele recente que considera mais grave?", new List<string> { "Sim", "Não" }));
            Perguntas.Add(new PerguntaResposta("Selecione sua necessidade:", new List<string> { "Acnes e cravos", "Ressecamento", "Melasma e cicatrizes", "Sensibilidade e irritação", "Prevenção de sinais", "Linhas finas e rugas", "Cuidados pele fumante" }));
        }
    }
}
