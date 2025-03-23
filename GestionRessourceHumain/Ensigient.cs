namespace ConsoleTpsApp.GestionRessourceHumain;
using System;
using System.Collections.Generic;

public class Ensigient:Personnel
{
    private string grade;
    private float v_h;
    private float nm_houresSuplemetaire;
    
    private Dictionary<string,List<Etudient>> groupes = new Dictionary<string,List<Etudient>>();
    
    public Ensigient(int code, string nom, string prenom,string bereau,float salaire,float prime,string grade,float v_h, float nmHouresSuplemetaire) 
        : base(code, nom, prenom,bereau,salaire,prime)
    {
        this.grade = grade;
        this.v_h = v_h;
        this.nm_houresSuplemetaire = nmHouresSuplemetaire;
    }

    
    // getters and setters 
    public string Grade
    {
        get => grade;
        set => grade = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float VH
    {
        get => v_h;
        set => v_h = value;
    }

    public float NmHouresSuplemetaire
    {
        get => nm_houresSuplemetaire;
        set => nm_houresSuplemetaire = value;
    }

    public Dictionary<string, List<Etudient>> Groups
    {
        get => groupes;
        set => groupes = value;
    }

    public override float CalculateSalaire()
    {
        throw new NotImplementedException();
    }


    public string ToString()
    {
        return base.ToString() + ", grade" + grade + ", v_h : " + v_h + ", nombres heures suplaimentaire : " + nm_houresSuplemetaire;
    }
}