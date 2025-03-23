namespace ConsoleTpsApp.GestionRessourceHumain;

public class Groupe
{
    private string nom;
    private List<Etudient> listEtudients = new List<Etudient>();

    public Groupe(string nom)
    {
        this.nom = nom;
    }
    
    
    
    // gettters and setters
    public string Nom
    {
        get => nom;
        set => nom = value ;
    }

    public List<Etudient> ListEtudients
    {
        get => listEtudients;
        set => listEtudients = value ;
    }


    public String toString()
    {
        return "nome de groupe : " +nom;
    }
    
}