// Information about the cost of a project

using System;
using System.Collections.Generic;

public class Coûts
{
    public int Id { get; set; } // Clé primaire
    public int ProjetId { get; set; } // Clé étrangère vers la table Projet
    public Projet Projet { get; set; } // Propriété de navigation pour la relation avec la table Projet
    public decimal CoûtMateriel { get; set; }
    public decimal CoûtMainOeuvre { get; set; }
    public decimal CoûtTotal => CoûtMateriel + CoûtMainOeuvre; // Calcul automatique du coût total
    
    public Coûts() {}
    
    public Coûts(int projetId, decimal coûtMateriel, decimal coûtMainOeuvre)
    {
        this.ProjetId = projetId;
        this.CoûtMateriel = coûtMateriel;
        this.CoûtMainOeuvre = coûtMainOeuvre;
    }
}