using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public string ListeCDs()
        {
            var cds = _fondDeCommerce.OfType<CD>().ToList();
            if (!cds.Any())
            {
                return "il n'y a pas de CD";
            }
            return $"il y a {cds.Count} CD(s) dans la liste :\n" + string.Join("\n", cds.Select(cd => $"- {cd.Groupe} - {cd.TitreDeLObjet}"));
        }

    }
}
