using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarySiteMarchand;

namespace UnitTestSiteMarchand
{
    [TestClass]
    public class UnitTestCompte
    {
         Compte compte;

        [TestInitialize]                                                // Permet de créer les objets tester par la suite
        public void SetUp()
        {
            compte = new Compte();
            compte.Depense = 120.00;
        }

        [TestCleanup]                                                   // On nettoie les objets utiliser par les tests
        public void CleanUp()
        {
            var PrivateObj = new PrivateType("ClassLibrarySiteMarchand", "ClassLibrarySiteMarchand.Compte");
            PrivateObj.SetStaticField("indexCompte", 0);
            compte = null;
        }


        // Test du constructeur public de la class Compte
        [TestMethod]
        public void PublicConstructorCompteTest()
        {
            var actualCode = compte.Code;
            var actualSolde = compte.Solde;
            var actualDepense = compte.Depense;
            var actualDateCreation = compte.DateCreation ;
            
            var expectedCode = "0001";
            var expectedSolde = 0.00;
            var expectedDepense = 120.00;
            var expectedDateCreation = DateTime.Today;

            Assert.AreEqual(expectedCode, actualCode);
            Assert.AreEqual(expectedSolde, actualSolde);
            Assert.AreEqual(expectedDepense, actualDepense);
            Assert.AreEqual(expectedDateCreation, actualDateCreation);
        }


        // Test de l'attribut Name de mon compte
        [TestMethod]
        public void CompteCodeTest()
        {
            var actual = compte.Code;
            var expected = "0001";
            Assert.AreEqual(expected, actual, "Compte code initialization is incorrect");
        }

        // Test de l'attribut Solde de mon compte
        [TestMethod]
        public void CompteSoldeTest()
        {
            var actual = compte.Solde;
            var expected = 0.00;
            Assert.AreEqual(expected, actual, "Compte Solde initialization is incorrect");
        }

        // Test de l'attribut Depense de mon compte
        [TestMethod]
        public void CompteDepenseTest()
        {
            var actual = compte.Depense;
            var expected = 120.00;
            Assert.AreEqual(expected, actual, "Compte depense initialization is incorrect");
        }

        // Test de l'attribut Date de creation de mon compte
        [TestMethod]
        public void CompteDateCreationTest()
        {
            var actual = compte.DateCreation.ToShortDateString();
            var expected = DateTime.Now.ToShortDateString();
            Assert.AreEqual(expected, actual, "Compte Date de creation initialization is incorrect");
        }

        //Test de la méthode depot qui ajoute son argument au solde du compte
        [TestMethod]
        public void Depot_WithValideNumber_UpdateSolde()
        {
            compte.Depot(145);
            double actual = compte.Solde;
            double expected = 145;
            Assert.AreEqual(expected, actual, " Quantite not credited correctly");
        }

        // Test de la méthode retirer qui retire son argument au solde du compe
        [TestMethod]
        public void Retirer_WithValideNumber_UpdateSolde()
        {
            compte.Depot(100);

            compte.Retirer(10);
            double actual = compte.Solde;
            double expected = 90;
            Assert.AreEqual(expected, actual, " Quantite not debited correctly");
        }

        // Test de la méthode retirer qui retire son argument au solde du compe
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Retirer_WhenNumberisGreaterThanSolde_ShouldThrowArgumentOfRange()
        {
            compte.Retirer(100);
        }

        // Test de la methode afficher qui renvoie un string
        [TestMethod]
        public void AfficherCompte_IsTypeOfString()
        {
            var RetourAffiche = compte.AfficherCompte();
            Assert.IsInstanceOfType(RetourAffiche, typeof(String));
        }

    }
}
