// Information sur les clients

using System;
using System.Collections.Generic;

public class Client
{
    public int Id { get; set; }
    public string Compagnie { get; set; }
    public string NomContact { get; set; }
    public string Courriel { get; set; }
    public string Telephone { get; set; }
    public string Adresse { get; set; }
    public string Ville { get; set; }
    public string Province { get; set; }
    public string Pays { get; set; }
    public List<Project> Projects { get; set; }
}
