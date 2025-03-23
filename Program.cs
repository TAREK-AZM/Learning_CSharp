// See https://aka.ms/new-console-template for more information

using ConsoleTpsApp.TP2;
using ConsoleTpsApp.GestionRessourceHumain;

using System;
using  Npgsql;
public class AppMain
{
    // this the tps 1,2,3
    // public static void Main(string[] args)
    // {
    //     // create Project
    //     Projet P1 = new Projet(212, "devloppemnt app web", 10);
    //
    //
    //     // create programmeurs
    //     Programmeur pr1 = new Programmeur(1, "al azami", "tarek", 1);
    //     Programmeur pr2 = new Programmeur(2, "bakali", "samir", 1);
    //     Programmeur pr3 = new Programmeur(3, "slami", "ahmed", 1);
    //     Programmeur pr4 = new Programmeur(4, "nassiri", "reda", 1);
    //     Programmeur pr5 = new Programmeur(5, "louah", "mohamed", 1);
    //     Programmeur pr6 = new Programmeur(6, "ben mgreda", "anass", 1);
    //
    //     // affecter les programmeurs vers un projet
    //     P1.AjouterProgrammeur(pr1);
    //     P1.AjouterProgrammeur(pr2);
    //     P1.AjouterProgrammeur(pr3);
    //     P1.AjouterProgrammeur(pr4);
    //     P1.AjouterProgrammeur(pr5);
    //     P1.AjouterProgrammeur(pr6);
    //
    //     // create consomation for programmeurs
    //     // pr1 2 consomaton
    //     P1.AjouterConsomation(pr1,1);
    //     P1.AjouterConsomation(pr1,1);
    //     // pr2 1 consomation
    //     P1.AjouterConsomation(pr2,1);
    //     // pr3 3 consomation
    //     P1.AjouterConsomation(pr3,1);
    //     P1.AjouterConsomation(pr3,2);
    //     P1.AjouterConsomation(pr3,1);
    //     // pr4 4 consomation
    //     P1.AjouterConsomation(pr4,2);
    //     P1.AjouterConsomation(pr4,1);
    //     P1.AjouterConsomation(pr4,2);
    //     P1.AjouterConsomation(pr4,1);
    //     // pr5 6 consomation
    //     P1.AjouterConsomation(pr5,2);
    //     P1.AjouterConsomation(pr5,1);
    //     P1.AjouterConsomation(pr5,1);
    //     P1.AjouterConsomation(pr5,2);
    //     P1.AjouterConsomation(pr5,1);
    //     P1.AjouterConsomation(pr5,1);
    //
    //
    //     // pr6 4 consomation
    //     P1.AjouterConsomation(pr6,1);
    //     P1.AjouterConsomation(pr6,2);
    //     P1.AjouterConsomation(pr6,1);
    //     P1.AjouterConsomation(pr6,2);
    //
    //
    //
    //
    //
    //
    //     // afficher les resultat des tasses consommer par sommaine
    //
    //     //int NmbTotalTassesConsomesDansSomaine = P1.AfficherNombresTotalsTassesConsommerDansSomaine(1);
    //    // Console.WriteLine("Nomb Totals des consomation sont:"+ NmbTotalTassesConsomesDansSomaine);
    //     
    //    /////////////// --- Test applicatioon de gestion des ressources humains//////////////
    //     //  Création de l'objet de gestion des ressources humaines
    //     RessourcesHumaines rh = new RessourcesHumaines();
    //
    //     //  Création de quelques enseignants
    //     Ensigient ens1 = new Ensigient(1, "Ali", "Ben", "Bureau 101", 12000, 2000, "PA", 300, 10);
    //     Ensigient ens2 = new Ensigient(2, "Fatima", "Zahra", "Bureau 102", 14000, 2500, "PH", 350, 5);
    //     
    //     //  Ajout des enseignants à la liste GRH
    //     rh.Ajouter_Personnel(ens1);
    //     rh.Ajouter_Personnel(ens2);
    //
    //     //  Création de groupes d'étudiants
    //     Groupe groupe1 = new Groupe("Groupe A");
    //     Groupe groupe2 = new Groupe("Groupe B");
    //     Groupe groupe3 = new Groupe("Groupe C");
    //     Groupe groupe4 = new Groupe("Groupe D");
    //     Groupe groupe5 = new Groupe("Groupe E");
    //
    //
    //     //  Création d'étudiants
    //     Etudient etud1 = new Etudient(101, "Khalid", "Omar", "Master 1", 15.5f);
    //     Etudient etud2 = new Etudient(102, "Sara", "Lahcen", "Master 1", 12.0f);
    //     Etudient etud3 = new Etudient(103, "Hassan", "Tariq", "Master 2", 13.5f);
    //
    //     //  Ajout des étudiants aux groupes
    //     rh.Ajouter_etudiant("Groupe A", etud1);
    //     rh.Ajouter_etudiant("Groupe A", etud2);
    //     rh.Ajouter_etudiant("Groupe B", etud3);
    //
    //     //  Assignation des groupes aux enseignants
    //     rh.Ajouter_groupe(1, groupe1);
    //     rh.Ajouter_groupe(2, groupe2);
    //     rh.Ajouter_groupe(2, groupe3);
    //     rh.Ajouter_groupe(2, groupe4);
    //     rh.Ajouter_groupe(2, groupe5);
    //
    //
    //     //  Affichage des enseignants
    //     Console.WriteLine("\n Liste des enseignants :");
    //     rh.Afficher_Enseignants();
    //
    //     //  Affichage des groupes
    //     Console.WriteLine("\n Affichage des étudiants du Groupe A :");
    //     rh.Afficher_grp("Groupe A");
    //
    //     Console.WriteLine("\n Affichage des étudiants du Groupe B :");
    //     rh.Afficher_grp("Groupe B");
    //
    //     //  Recherche d'un enseignant
    //     Console.WriteLine("\n Recherche de l'enseignant avec ID 1 :");
    //     int indexEns = rh.Rechercher_Ens(1);
    //     Console.WriteLine(indexEns != -1 ? $"L'enseignant est à la position {indexEns}" : "Enseignant introuvable");
    //
    //     // Affichage d'un enseignant et ses groupes
    //     Console.WriteLine("\n Affichage des détails de l'enseignant 1 et ses groupes :");
    //     rh.Afficher_ens(2);
    //
    //     //  Affichage d'un étudiant par son code
    //     Console.WriteLine("\n Affichage de l'étudiant 102 :");
    //     rh.Afficher_etd(102);
    // }
    //
    //

    
    // this the base donner 
    public static void Main(string[] args)
    {
        
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=pgufc;Database=C_sharp");
        conn.Open();
        Console.WriteLine("Connection to PostgreSQL established successfully.");
        NpgsqlCommand command = new NpgsqlCommand("SELECT version()", conn);
        string version = command.ExecuteScalar()?.ToString();
        Console.WriteLine($"PostgreSQL version: {version}");


    }
    
} 