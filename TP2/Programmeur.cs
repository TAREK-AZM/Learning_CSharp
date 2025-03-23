namespace ConsoleTpsApp.TP2;

public class Programmeur
{
    private int id;
    private string nom;
    private string prenom;
    private int bureau;
    

    public Programmeur(int id, string nom, string prenom, int bureau)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.bureau = bureau;
    }

   
    public int Id { get => id; set => id = value; }
    public string Nom { get => nom; set => nom = value; }
    public string Prenom { get => prenom; set => prenom = value; }
    public int Bureau { get => bureau; set => bureau = value; }
    
    
    public Boolean EqualsProgrammeur(Programmeur programmeur)
    {
        return programmeur.id == this.id;
    }

    public string toString()
    {
        return "nom:" + nom + ", prenom:" + prenom + ", bureau:" + bureau;
    }
}