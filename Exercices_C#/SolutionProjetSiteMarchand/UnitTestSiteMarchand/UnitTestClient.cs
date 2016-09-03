using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarySiteMarchand;


namespace UnitTestSiteMarchand
{
    [TestClass]
    public class UnitTestClient
    {
        Client client;

        [TestInitialize]                                                // Permet de créer les objets tester par la suite
        public void SetUp()
        {
            client = new Client("GAUDRON","Fabien", new DateTime(1983,08,03),"14 route de Briare 45250 OUSSON", "fabien.gaudron@gmail.com", new Compte());
            client.Compte.Depense = 120.00;
            client.Compte.Depot(50.00);
        }

        [TestCleanup]                                                   // On nettoie les objets utiliser par les tests
        public void CleanUp()
        {
           var PrivateObj = new PrivateType("ClassLibrarySiteMarchand", "ClassLibrarySiteMarchand.Compte");
           PrivateObj.SetStaticField("indexCompte", 0);
           client = null;
        }


        // Test du constructeur public de la class Client
        [TestMethod]
        public void PublicConstructorClientTest()
        {
            var actualidPersonne = client.IdPersonne;
            var actualNom = client.Nom;
            var actualPrenom = client.Prenom;
            var actualDateNaissance = client.DateNaissance.ToShortDateString();
            var actualAdresse = client.Adresse;
            var actualAdresseMail = client.AdresseMail;
            var actualCompteCode = client.Compte.Code;
            var actualCompteDateCreation = client.Compte.DateCreation.ToShortDateString();
            var actualCompteDepense = client.Compte.Depense;
            var actualCompteSolde = client.Compte.Solde;
            var expectedidPersonne = "0001_GAUDRONF";
            var expectedNom = "GAUDRON";
            var expectedPrenom = "Fabien";
            var expectedDateNaissance = new DateTime(1983,08,03).ToShortDateString();
            var expectedAdresse = "14 route de Briare 45250 OUSSON";
            var expectedAdresseMail = "fabien.gaudron@gmail.com";
            var expectedCompteCode = "0002";
            var expectedCompteDateCreation = DateTime.Today.ToShortDateString();
            var expectedCompteDepense = 120.00;
            var expectedCompteSolde = 50.00;
            Assert.AreEqual(expectedidPersonne, actualidPersonne);
            Assert.AreEqual(expectedNom, actualNom);
            Assert.AreEqual(expectedPrenom, actualPrenom);
            Assert.AreEqual(expectedDateNaissance, actualDateNaissance);
            Assert.AreEqual(expectedAdresse, actualAdresse);
            Assert.AreEqual(expectedAdresseMail,actualAdresseMail);
            Assert.AreEqual(expectedCompteCode, actualCompteCode);
            Assert.AreEqual(expectedCompteDateCreation, actualCompteDateCreation);
            Assert.AreEqual(expectedCompteDepense, actualCompteDepense);
            Assert.AreEqual(expectedCompteSolde, actualCompteSolde);
        }


        // Test de l'attribut idPersonne de client
        [TestMethod]
        public void ClientIdPersonneTest()
        {
            var actual = client.IdPersonne;
            var expected = "0002_GAUDRONF";
            Assert.AreEqual(expected, actual, "Client ID initialization is incorrect");
        }


        // Test de l'attribut Nom de client
        [TestMethod]
        public void ClientNomTest()
        {
            var actual = client.Nom;
            var expected = "GAUDRON";
            Assert.AreEqual(expected, actual, "Client Nom initialization is incorrect");
        }

        // Test de l'attribut Prenom de client
        [TestMethod]
        public void ClientPrenomTest()
        {
            var actual = client.Prenom;
            var expected = "Fabien";
            Assert.AreEqual(expected, actual, "Client Prenom initialization is incorrect");
        }

        // Test de l'attribut date de Naissance de client
        [TestMethod]
        public void ClientDateNaissanceTest()
        {
            var actual = client.DateNaissance.ToShortDateString();
            var expected = new DateTime(1983,08,03).ToShortDateString();
            Assert.AreEqual(expected, actual, "Date de Naissance initialization is incorrect");
        }

        // Test de l'attribut Adresse de client
        [TestMethod]
        public void ClientAdresseTest()
        {
            var actual = client.Adresse;
            var expected = "14 route de Briare 45250 OUSSON";
            Assert.AreEqual(expected, actual, "Client Adresse initialization is incorrect");
        }

        // Test de l'attribut Adresse Mail de client
        [TestMethod]
        public void ClientAdresseMailTest()
        {
            var actual = client.AdresseMail;
            var expected = "fabien.gaudron@gmail.com";
            Assert.AreEqual(expected, actual, "Client AdresseMail initialization is incorrect");
        }

        // Test de l'attribut Compte du client est non NULL et bien du type Compte
        [TestMethod]
        public void ClientCompte_IsNotNull_And_IsTypeOfCompte()
        {
            var actual = client.Compte;
            Assert.IsNotNull(actual, "Compte Client is not created");
            Assert.IsInstanceOfType(actual,typeof(Compte), "Compte Client is not Type of Compte");
        }


        // Test de la methode isValideMail qui retour un FormatException
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void isValideMail_WhenIsNotAdresseMail_ShouldThrowFormatException()
        {
        Client.IsValideMail("NotAdresseMail");
        }

        // Test de la methode isValideMail qui renvoi true
        [TestMethod]
        public void isValideMailTest()
        {
            var actual = Client.IsValideMail(client.AdresseMail);
            var expected = true;
            Assert.AreEqual(expected, actual,"Methode don't work");
        }

        // Test de la methode isValideAdressePostale qui retour un FormatException
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void isValideAdressePostale_WhenIsNotAdressePostale_ShouldThrowFormatException()
        {
            Client.IsValideAdressePostale("NotAdresse");
        }

        // Test de la methode isValideAdressePostale qui renvoi true
        [TestMethod]
        public void isValideAdressePostaleTest()
        {
            var actual = Client.IsValideAdressePostale(client.Adresse);
            var expected = true;
            Assert.AreEqual(expected, actual, "Methode don't work");
        }

        // Test de la methode afficher qui renvoie un string
        [TestMethod]
        public void AfficherClient_IsTypeOfString()
        {
            var RetourAffiche = client.AfficherClient();
            Assert.IsInstanceOfType(RetourAffiche, typeof(String));
        }

    }
}
