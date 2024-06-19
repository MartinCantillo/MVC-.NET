
public class Usuario
{
    public Usuario(int _id, string _nome, string _apellido, string _cargo)
    {
        this._id = _id;
        this._nome = _nome;
        this._apellido = _apellido;
        this._cargo = _cargo;
    }

    private int _id { set; get; }
    private string _nome { set; get; }

    private string _apellido { set; get; }

    private string _cargo { set; get; }
}