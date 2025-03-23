namespace ConsoleTpsApp.TP2;

using System;
using System.Collections.Generic;
public class Projet
{
    private int code;
    private string sujet;
    private int  duree;

    private List<Programmeur> programmeurs = new List<Programmeur>();
    private List<ConsoCaffe> ListConsomations = new List<ConsoCaffe>();

    public Projet(int code, string sujet, int duree)
    {
        this.code = code;
        this.sujet = sujet;
        this.duree = duree;
    }
    
    
    public int Code { get => code; set => code = value; }
    public string Sujet { get => sujet; set => sujet = value; }
    public int Duree { get => duree; set => duree = value; }
    public List<Programmeur> ProgrameurList { get => programmeurs;
        set => programmeurs = value;
    }
    public List<ConsoCaffe> ListConsomationList { get => ListConsomations;
        set => ListConsomations = value;
    }
    
    // Ajouter un programeur

    public void AjouterProgrammeur(Programmeur programmeur)
    {
        programmeurs.Add(programmeur);
    }
    
    // suprimer un programeur
    public void DeleterProgrammeur(Programmeur programmeur)
    {
        programmeurs.Remove(programmeur);
    }
    
    // Recherche sur programeur
    public Programmeur GetProgrammeur(Programmeur programmeur)
    {
        return programmeurs.Find(programmeur => programmeur.EqualsProgrammeur(programmeur));
    }
    
    // afficher la list de s programmeur 
    public void  AfficherProgrammeurs()
    {
        if (programmeurs.Count > 0)
        {
            foreach (Programmeur p in programmeurs)
            {
                Console.WriteLine(p.ToString());
                
            }
        }
        Console.WriteLine("Pas des programeurs");
    }
   
    // Ajouter un consomation a un programmeur
    public void AjouterConsomation(Programmeur programmeur, int noSomaine)
    {
      
            Boolean consomationFounded = false;
            foreach (ConsoCaffe conso in ListConsomations)
            {
                if (conso.ProgrammeurId == programmeur.Id && conso.NoSomaine == noSomaine)
                {
                    conso.Nb_Tasses++;
                    consomationFounded = true;
                    break;
                }
               
            }

            if (!consomationFounded)
            {
                ListConsomations.Add(new ConsoCaffe(noSomaine,programmeur.Id,1));
            }
        
        
        
    }
    
    // Changer le Bereau d'un programmeur
    public void ChngerBereauProgrammeurs(Programmeur programmeur,int noBereau)
    {
        if (programmeurs.Count > 0)
        {
                Programmeur p = programmeurs.Find(programmeur => programmeur.Equals(programmeur));
                p.Bureau = noBereau;
        }
        
    }
    
    // afficher le nombres de tasses consommes par un programmeur

    public int AfficherNombresTotalsTassesConsommerDansSomaine(int noSomaine)
    {
        List <ConsoCaffe> CaffesParsomaine = ListConsomations.FindAll(caffe => caffe.NoSomaine == noSomaine);
        int nbTasses = 0;
        foreach (ConsoCaffe caffe in CaffesParsomaine)
        {
            Console.WriteLine("Nomre tasses"+caffe.Nb_Tasses);
            nbTasses = nbTasses + caffe.Nb_Tasses;
        }
        return nbTasses;
    }
    
    
}