namespace Model
{
    public class Jogo
    {
        public string nome { get; }
        public string descricao { get; }
        public string img { get; }

        public Jogo(string nome, string descricao, string img)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.img = img;
        }
    }
}