using ProjetEntityFrameworkCodeFirst.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Dao
{
    class DaoImpl : IDao
    {

        public Personne AjouterPersonne(Personne p)
        {
            // initialisation du contexte PERSONNE
            // Utilise le contexte PersonneContexte pour exécuter les lignes suivante
            using (var MonDataBase = new Dao.PersonneContext())
            {
                // Ajout de la personne au DbSet
                MonDataBase.Personnes.Add(p);

                // Mise a jour de la base de données
                MonDataBase.SaveChanges();
                
                // Envoie du retour demandé
                return p;
            }

        }

        public Personne TrouverPersonne(int id)
        {
            using (var db = new Dao.PersonneContext())
            {

                return db.Personnes.Find(id);

            }
        }
    }
}
