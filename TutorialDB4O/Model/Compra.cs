namespace Model
{
    public class Compra
    {
        public string nome { get; }
        public double preco { get; }

        public Compra(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}