class EtreVivant
{
    public DateTime DateDeNaissance { get; set; }

    // Constructeur
    public EtreVivant()
    {
        this.DateDeNaissance = DateTime.Now;
    }

    public EtreVivant(DateTime DateNaissance)
    {
        DateDeNaissance = DateNaissance;
    }

    // Méthode
    public int GetAge()
    {
        return DateTime.Now.Year - DateDeNaissance.Year;
    }
}