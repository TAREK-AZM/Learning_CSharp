namespace ConsoleTpsApp.TP3;

public abstract class User
{
    private int id;
    private string nom;
    private string prenom;

    public User(int id, string nom, string prenom)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nom
    {
        get => nom;
        set => nom = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Prenom
    {
        get => prenom;
        set => prenom = value ?? throw new ArgumentNullException(nameof(value));
    }
}