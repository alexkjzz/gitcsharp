public class Boss : Employe
{
    public Boss(string nom, double salaire, string HobbyHonteux) : base(nom, salaire, HobbyHonteux)
    {

    }

    public new string Travail()
    {
        return $"{this.Nom} zzz $$$ zzz !";
    }

    public void Augmente(Employe employe)
    {
        employe.Salaire += 100;
    }
}