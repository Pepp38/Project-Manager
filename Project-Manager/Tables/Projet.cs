using System;
using System.Collections.Generic;

public class Projet
{
    public int Id { get; set; } // Clé primaire
    public string Nom { get; set; }
    public string Description { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFinPrevue { get; set; }
    public DateTime? DateFinReelle { get; set; } // Peut être null si le projet n'est pas encore terminé
    public Avancements Avancements { get; set; }
    public Coûts Coûts { get; set; } 
    public decimal Budget { get; set; }
    public decimal EcartVenteBudget => VenteReelle - Budget; // Calcul automatique de l’écart

    // Clé étrangère vers le Client
    public int ClientId { get; set; } 
    public Client Client { get; set; } // Propriété de navigation pour la relation avec la table Client

    // Clé étrangère vers le Manager
    public int ManagerId { get; set; } 
    public Manager Manager { get; set; } // Propriété de navigation pour la relation avec la table Manager

    // Relation un-à-plusieurs avec la table Depenses
    public ICollection<Depense> Depenses { get; set; } = new List<Depense>();

    // Relation plusieurs-à-plusieurs avec Employe via une table de liaison
    public ICollection<EmployeProjet> EmployesProjets { get; set; } = new List<EmployeProjet>();

    public Projet() {}

    public Projet(string nom, string description, DateTime dateDebut, DateTime dateFinPrevue, int clientId, int managerId)
    {
        this.Nom = nom;
        this.Description = description;
        this.DateDebut = dateDebut;
        this.DateFinPrevue = dateFinPrevue;
        this.ClientId = clientId;
        this.ManagerId = managerId;
    }
}
