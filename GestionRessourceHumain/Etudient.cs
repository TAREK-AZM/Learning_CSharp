namespace ConsoleTpsApp.GestionRessourceHumain;

public class Etudient:Personne
{
    private string niveau;
    private float moyenne;


    public Etudient(int code, string nom, string prenom, string niveau, float moyenne) 
        : base(code, nom, prenom)
    {
        this.niveau = niveau;
        this.moyenne = moyenne;
    }

    public override float CalculateSalaire()
    {
        return 0;
    }

    public string ToString()
    {
        return base.ToString() + ", niveau :"+ niveau+", moyenne :"+ moyenne;
    }
    

}