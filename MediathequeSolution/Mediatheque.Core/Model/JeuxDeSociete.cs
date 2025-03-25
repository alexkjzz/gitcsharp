namespace Mediatheque.Core.Model
{
    public class JeuxDeSociete: ObjetDePret
    {
        private double v1;
        private string v2;
        private TypeJeuxDeSociete carte;

        public JeuxDeSociete(string titreDeLObjet, double v1, string v2, TypeJeuxDeSociete carte) : base(titreDeLObjet)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.carte = carte;
        }

        public JeuxDeSociete(string titreDeLObjet, int ageMini, int ageMaxi, string editeur, TypeJeuxDeSociete type) : base(titreDeLObjet)
        {
            AgeMinimum = ageMini;
            AgeMaximum = ageMaxi;
            Editeur = editeur;
            TypeJeux = type;
        }

        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public string Editeur { get; set; }
        public TypeJeuxDeSociete TypeJeux { get; set; }
    }
}
