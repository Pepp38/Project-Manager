// La table Avancements va tenir à jour les avancements réelles des projets. On doit donc établir des étapes et des dates pour chaque projet. L'avancements sera un pourcentages des étapes complétées vs non complétées.

using System;
using System.Collections.Generic;

public class Avancements
{
    public int Id { get; set; } // Clé primaire
    public int ProjetId { get; set; } // Clé étrangère vers la table Projet
    public Projet Projet { get; set; } // Propriété de navigation pour la relation avec la table Projet
    public string Etape { get; set; }
    public DateTime DateEtape { get; set; }
    public int Pourcentage { get; set; }
    
    public Avancements() {}
    
    public Avancements(int projetId, string etape, DateTime date, int pourcentage)
    {
        this.ProjetId = projetId;
        this.Etape = etape;
        this.Date = date;
        this.Pourcentage = pourcentage;
    }
}

