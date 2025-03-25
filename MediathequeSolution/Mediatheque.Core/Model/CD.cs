namespace Mediatheque.Core.Model
{

    public class CD : ObjetDePret
    {
        public string Groupe { get; set; }

        public CD(string groupe, string titreDeLObjet) : base(titreDeLObjet)
        {
            Groupe = groupe;
        }
    }
}
