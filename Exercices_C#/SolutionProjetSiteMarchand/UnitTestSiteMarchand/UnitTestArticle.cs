using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarySiteMarchand;

namespace UnitTestSiteMarchand
{
    [TestClass]
    public class UnitTestArticle
    {
        Article article;

        [TestInitialize]                                                // Permet de créer les objets tester par la suite
        public void SetUp()
        {
            article = new Article("Tasse","Accessoires",125.45,50);
        }

        [TestCleanup]                                                   // On nettoie les objets utiliser par les tests
        public void CleanUp()
        {
            article = null;
        }


        // Test du constructeur public de la class Article
        [TestMethod]
        public void PublicConstructorArticleTest()
        {
            var actualName = article.Name;
            var actualCategorie = article.Categorie;
            var actualPrix = article.Prix;
            var actualQuantite = article.Quantite;
            var actualidArticle = article.IdArticle;
            var expectedName = "Tasse";
            var expectedCategorie = "Accessoires";
            var expectedPrix = 125.45;
            var expectedQuantite = 50;
            var expectedidArticle = "0001";
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedCategorie, actualCategorie);
            Assert.AreEqual(expectedPrix, actualPrix);
            Assert.AreEqual(expectedQuantite, actualQuantite);
            Assert.AreEqual(expectedidArticle, actualidArticle);
        }


        // Test de l'attribut Name de mon article
        [TestMethod]
        public void ArticleNameTest()
        {
            var actual = article.Name;
            var expected = "Tasse";
            Assert.AreEqual(expected, actual, "Article Name initialization is incorrect");
        }

        // Test de l'attribut Categorie de mon article
        [TestMethod]
        public void ArticleCategorieTest()
        {
            var actual = article.Categorie;
            var expected = "Accessoires";
            Assert.AreEqual(expected, actual, "Article Categorie initialization is incorrect");
        }

        // Test de l'attribut idArticle de mon article
        [TestMethod]
        public void Article_idArticleTest()
        {
            var actual = article.IdArticle;
            var expected = "0004";                      // A modifier si on ajoute un autre test en amont
            Assert.AreEqual(expected, actual, "idArticle initialization is incorrect");
        }

        // Test de l'attribut Categorie de mon article
        [TestMethod]
        public void ArticlePrixTest()
        {
            var actual = article.Prix;
            var expected = 125.45;
            Assert.AreEqual(expected, actual, "Article Prix initialization is incorrect");
        }

        // Test de l'attribut Quantite de mon article
        [TestMethod]
        public void ArticleQuantiteTest()
        {
            var actual = article.Quantite;
            var expected = 50;
            Assert.AreEqual(expected, actual, "Article Quantite initialization is incorrect");
        }

        // Test de la méthode depot qui ajoute son argument à la quantité de l'article
        [TestMethod]
        public void Depot_WithValideNumber_UpdateQuantite()
        {
            article.Depot(10);
            int actual = article.Quantite;                                         
            int expected = 60;
            Assert.AreEqual(expected, actual, " Quantite not credited correctly");    
        }

        // Test de la méthode retirer qui ajoute son argument à la quantité de l'article
        [TestMethod]
        public void Retirer_WithValideNumber_UpdateQuantite()
        {
            article.Retirer(10);
            int actual = article.Quantite;
            int expected = 40;
            Assert.AreEqual(expected, actual, " Quantite not debited correctly");
        }

        // Test de la methode afficher qui renvoie un string
        [TestMethod]
        public void AfficherArticle_IsTypeOfString() 
        {
            var RetourAffiche = article.AfficherArticle();
            Assert.IsInstanceOfType(RetourAffiche,typeof(String));
        }

    }
}
