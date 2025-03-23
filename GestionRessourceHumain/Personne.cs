namespace ConsoleTpsApp.GestionRessourceHumain;

public abstract class Personne
{
    private int code;
    private string nom;
    private string prenom;

    public Personne(int code, string nom, string prenom)
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;
    }

    public int Code
    {
        get => code;
        set => code = value;
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
    public abstract float CalculateSalaire();


    public string ToString()
    {
        return "code :"+ code + ", nom : " + nom + ", prenom : " + prenom;
    }
}