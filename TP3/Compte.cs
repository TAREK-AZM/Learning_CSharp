namespace ConsoleTpsApp.TP3;

public class Compte
{
    private int id;
    private float solde;
    private int clientId;

    public Compte(int id, float solde, int clientId)
    {
        this.id = id;
        this.solde = solde;
        this.clientId = clientId;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public float Solde
    {
        get => solde;
        set => solde = value;
    }

    public int ClientId
    {
        get => clientId;
        set => clientId = value;
    }
}