using ConsoleTpsApp.TP3;

namespace ConsoleTpsApp.GestionRessourceHumain;

public class Administrateur:Personnel
{
    public Administrateur(int code, string nom, string prenom,string bereau,float salaire,float prime = 0)
        : base(code, nom,prenom,bereau,salaire,prime)
    {
        
    }


    public override float CalculateSalaire()
    {
        throw new NotImplementedException();
    }
}