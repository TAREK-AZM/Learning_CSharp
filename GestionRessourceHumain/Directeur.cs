namespace ConsoleTpsApp.GestionRessourceHumain;

public class Directeur:Personnel
{
    public static Directeur directeur;

  
    private Directeur(int code, string nom, string prenom,string bereau,float salaire,float prime = 0)
        : base(code, nom,prenom,bereau,salaire,prime)
    {
        if (directeur == null)
        {
            directeur = new Directeur(code,nom,prenom,bereau,salaire);
        }
        
        
    }

    public override float CalculateSalaire()
    {
        return 0;
    }
    
    
    // methose getinstance
    public static Directeur GetInstance()
    {
        return directeur;
    }
    
}