using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class ListeCDsShould
    {
        [TestMethod]
        public void ReturnMessage_WhenNoCD()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);

            // Act
            string actual = mediathequeService.ListeCDs();

            // Assert
            Assert.AreEqual("il n'y a pas de CD", actual);
        }

        [TestMethod]
        public void ReturnMessage_siQueJeuxDeSociete()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 34 cartes", 3.99, "Auchan", TypeJeuxDeSociete.Carte));

            // Act
            string actual = mediathequeService.ListeCDs();

            // Assert
            Assert.AreEqual("il n'y a pas de CD", actual);
        }

        [TestMethod]
        public void ReturnTrue_siQueCDs()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Spice Girls", "Spice World"));
            mediathequeService.AddObjet(new CD("Offspring", "Smash"));

            // Act
            string actual = mediathequeService.ListeCDs();


            // Assert
            string expected = "il y a 2 CD(s) dans la liste :\n- Spice Girls - Spice World\n- Offspring - Smash";
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ReturnTrue_siMixObjects()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Pink Floyd", "The Wall"));
            mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3.99, "Carrefour", TypeJeuxDeSociete.Carte));
            mediathequeService.AddObjet(new CD("Queen", "A Night at the Opera"));

            // Act
            string actual = mediathequeService.ListeCDs();

            // Assert
            string expected = "il y a 2 CD(s) dans la liste :\n- Pink Floyd - The Wall\n- Queen - A Night at the Opera";
            Assert.AreEqual(expected, actual);
        }
    }
}
