public interface IEmploye {
    string MaPropriete {get; set;}
    string MaPropriete2 {get; set;}
    int Calcul(int p1, int p2);

    double Toto();

};

public class ImplementeInterface : IEmploye
{
    public string MaPropriete { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string MaPropriete2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Calcul(int p1, int p2)
    {
        throw new NotImplementedException();
    }

    public double Toto()
    {
        throw new NotImplementedException();
    }
}