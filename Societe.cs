public class Societe
{
    public string Nom { get; set; }
    private List<Employe> Employes { get; set; }

    public Societe(string nom)
    {
        this.Nom = nom;
        this.Employes = new List<Employe>();
    }

    public void Embauche(Employe employe)
    {
        this.Employes.Add(employe);
    }

    public string GetChef()
    {
        foreach (Employe employe in Employes)
        {
            if (employe is Boss)
            {
                return employe.Nom;
            }
        }
        return "Pas de chef";
    }

    public double CalculSommeSalaire()
    {
        double somme = 0;
        foreach (Employe employe in Employes)
        {
            somme += employe.Salaire;
        }
        return somme;
    }

    public string Travail()
    {
        string travail = "";
        foreach (Employe employe in Employes)
        {
            travail += employe.Travail() + "\n";
        }
        return travail;
    }

    public string Stalker()
    {
        string hobby = "";
        foreach (Employe employe in Employes)
        {
            hobby += $"{employe.Nom} : {employe.HobbyHonteux}, ";
        }
        return hobby;
    }    
}