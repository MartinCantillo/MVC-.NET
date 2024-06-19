namespace Models
{
    

public class Usuario
{
    public Usuario(int id, string nome, string apellido, string cargo)
    {
        this.id = id;
        this.nome = nome;
        this.apellido = apellido;
        this.cargo = cargo;
    }

    public  int id { set; get; }
    public string nome { set; get; }

    public string apellido { set; get; }

    public string cargo { set; get; }
}
}