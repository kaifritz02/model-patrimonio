namespace PatrimonioSenaiTaguatinga.Entities
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Nivel(string nome)
        {
            Nome = nome;
        }
        public ICollection<Usuario> Usuario { get; set; } = null!;
    }
}