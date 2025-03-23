namespace ConsoleTpsApp.TP2;


public class ConsoCaffe
{
    private int no_Somaine;
    private int programmeurId;
    private int nb_Tasses ;

    public ConsoCaffe(int no_Somaine, int programmeurId, int nb_Tasses)
    {
        this.no_Somaine = no_Somaine;
        this.programmeurId = programmeurId;
        this.nb_Tasses = nb_Tasses;
    }
    public int NoSomaine {get => no_Somaine;set => no_Somaine = value;}
    public int ProgrammeurId {get => programmeurId; set => programmeurId = value;}
    public int Nb_Tasses {get => nb_Tasses;set => nb_Tasses = value;}
    
}