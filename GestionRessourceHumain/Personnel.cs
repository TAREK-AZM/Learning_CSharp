namespace ConsoleTpsApp.GestionRessourceHumain;

public class Personnel:Personne
{
    private string  bereau;
    private float salaire;
    private float prime;

    public Personnel(int code, string nom, string prenom,string bereau, float salaire, float prime)
        :base(code,nom,prenom)
    {
        this.bereau = bereau;
        this.salaire = salaire;
        this.prime = prime;
        
    }

    public string Bereau
    {
        get => bereau;
        set => bereau = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Salaire
    {
        get => salaire;
        set => salaire = value;
    }

    public float Prime
    {
        get => prime;
        set => prime = value;
    }


    public override float CalculateSalaire()
    {
        throw new NotImplementedException();
    }


    public string ToString()
    {
        return base.ToString()+ ", bereau : " + bereau + ", salaire : " + salaire;
    }
}