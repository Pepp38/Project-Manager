using System;
using System.Collections.Generic;

public class Client
{
    public int Id { get; set; }  // Clé primaire pour le client
    public string Compagnie { get; set; }  // Nom de la compagnie du client
    public string NomContact { get; set; }  // Nom de la personne contact
    public string Ville { get; set; }  // Ville du client
    public string Province { get; set; }  // Province du client
    public string Pays { get; set; }  // Pays du client

    // Relation un-à-plusieurs : un client peut avoir plusieurs projets
    public List<Projet> Projets { get; set; } = new List<Projet>();
}
