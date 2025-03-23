namespace ConsoleTpsApp.GestionRessourceHumain;
using System;
using System.Collections.Generic;

public class RessourcesHumaines : IRessourcesHumaines
{
    // Liste générale des ressources humaines
    private List<Personnel> GRH = new List<Personnel>();
    private Dictionary<string, Groupe> groupes = new Dictionary<string, Groupe>();

    //  Permet d'afficher les enseignants et leurs groupes
    public void Afficher_Enseignants()
    {
        foreach (var personnel in GRH)
        {
            if (personnel is Ensigient enseignant)
            {
                Console.WriteLine(enseignant.ToString());

                if (enseignant.Groups.Count > 0)
                {
                    Console.WriteLine("  Groupes enseignés :");
                    foreach (var groupe in enseignant.Groups)
                    {
                        Console.WriteLine($"    - {groupe.Key} ({groupe.Value.Count} étudiants)");
                    }
                }
            }
        }
    }

    //  Recherche un enseignant par code et retourne son index ou -1 s'il n'existe pas
    public int Rechercher_Ens(int code)
    {
        for (int i = 0; i < GRH.Count; i++)
        {
            if (GRH[i] is Ensigient enseignant && enseignant.Code == code)
            {
                return i;
            }
        }
        return -1;
    }

    //  Ajoute un étudiant à un groupe existant
    public void Ajouter_etudiant(string nomGroup, Etudient etudiant)
    {
        if (groupes.ContainsKey(nomGroup))
        {
            groupes[nomGroup].ListEtudients.Add(etudiant);
            Console.WriteLine($"Étudiant {etudiant.Nom} ajouté au groupe {nomGroup}.");
        }
        else
        {
            Console.WriteLine($"Le groupe {nomGroup} n'existe pas.");
        }
    }

    //  Affecte un groupe à un enseignant existant
    public void Ajouter_groupe(int idEns, Groupe groupe)
    {
        int index = Rechercher_Ens(idEns);
        if (index != -1)
        {
            var enseignant = (Ensigient)GRH[index];
            enseignant.Groups[groupe.Nom] = groupe.ListEtudients;
            groupes[groupe.Nom] = groupe;
            Console.WriteLine($"Groupe {groupe.Nom} ajouté à l'enseignant {enseignant.Nom}.");
        }
        else
        {
            Console.WriteLine("Enseignant introuvable.");
        }
    }

    //  Affiche les étudiants d’un groupe
    public void Afficher_grp(string nomGroup)
    {
        if (groupes.ContainsKey(nomGroup))
        {
            Console.WriteLine($"Groupe: {nomGroup}");
            foreach (var etudiant in groupes[nomGroup].ListEtudients)
            {
                Console.WriteLine($"  - {etudiant.ToString()}");
            }
        }
        else
        {
            Console.WriteLine($"Le groupe {nomGroup} n'existe pas.");
        }
    }

    // Affiche un étudiant par son code
    public void Afficher_etd(int codeEtd)
    {
        foreach (var groupe in groupes.Values)
        {
            foreach (var etudiant in groupe.ListEtudients)
            {
                if (etudiant.Code == codeEtd)
                {
                    Console.WriteLine(etudiant.ToString());
                    return;
                }
            }
        }
        Console.WriteLine("Étudiant introuvable.");
    }

    //  Affiche un enseignant et ses groupes
    public void Afficher_ens(int idEns)
    {
        int index = Rechercher_Ens(idEns);
        if (index != -1)
        {
            var enseignant = (Ensigient)GRH[index];
            Console.WriteLine(enseignant.ToString());

            if (enseignant.Groups.Count > 0)
            {
                Console.WriteLine("Groupes enseignés :");
                foreach (var groupe in enseignant.Groups)
                {
                    Console.WriteLine($"  - {groupe.Key} ({groupe.Value.Count} étudiants)");
                }
            }
        }
        else
        {
            Console.WriteLine("Enseignant introuvable.");
        }
    }

    //  Ajoute un membre du personnel (Enseignant ou Administrateur)
    public void Ajouter_Personnel(Personnel personnel)
    {
        GRH.Add(personnel);
        Console.WriteLine($"Personnel {personnel.Nom} ajouté.");
    }
}
