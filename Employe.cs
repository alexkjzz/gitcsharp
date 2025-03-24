public interface IEmploye1
{
    string Nom { get; set; }
    double Salaire { get; set; }

    string Travail();
}

public class Employe : Personne, IEmploye1
{
    public double Salaire { get; set; }

    public Employe(string nom, double salaire, string HobbyHonteux) : base(nom, HobbyHonteux)
    {
        Salaire = salaire;
    }

    public string Travail()
    {
        return $"{this.Nom} travaille !";
    }
}