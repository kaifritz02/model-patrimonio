namespace PatrimonioSenaiTaguatinga.Entities
{
    public class Usuario
    {

     public int Id { get; set; }

     public string Nome { get;  set;}

     public string Sobrenome { get; set;}

     public string Login { get; set;}

     public int Senha { get; set; }

     public int IdNivel { get; set;}
 
     public Usuario(string nome,  string sobrenome, string login, int senha, int idNivel)
     {
        Nome = nome;
        Sobrenome = sobrenome; 
        Login = login;
        Senha = senha;
        IdNivel = idNivel;
     }

     public Nivel Nivel { get; set ;} = null!;
}
} 
