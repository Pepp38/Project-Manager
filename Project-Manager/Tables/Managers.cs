// Managers information is stored in the Managers table.

using System;
using System.Collections.Generic;

public class Managers
{
    public int Id { get; set; } // Clé primaire
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public DateTime DateEmbauche { get; set; }
    public decimal Salaire { get; set; }
    public decimal Prime { get; set; }
    public decimal SalaireTotal => Salaire + Prime; // Calcul automatique du salaire total

    // Relation un-à-plusieurs avec la table Projet
    public ICollection<Projet> Projets { get; set; } = new List<Projet>();

    public Managers() {}

    public Managers(string nom, string prenom, string email, string telephone, string poste, DateTime dateEmbauche, decimal salaire, decimal prime)
    {
        this.Nom = nom;
        this.Prenom = prenom;
        this.DateEmbauche = dateEmbauche;
        this.Salaire = salaire;
        this.Prime = prime;
    }
}