public class Personne
{
    public string Nom { get; set; }
    public string HobbyHonteux { get; set;}

    public Personne(string nom, string hobbyHonteux)
    {
        Nom = nom;
        HobbyHonteux = hobbyHonteux;
    }

}