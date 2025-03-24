static class Helper
{
    // Méthode
    public static void Test(int valeur)
    {
        valeur++;
    }

    public static void TestEtreVivant(EtreVivant etreVivant)
    {
        etreVivant.DateDeNaissance = etreVivant.DateDeNaissance.AddYears(1);
    }

    public static void Test(DateTime valeur)
    {
        valeur = valeur.AddYears(1);
    }
}