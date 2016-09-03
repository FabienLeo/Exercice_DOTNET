using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetEntityFrameworkCodeFirst.Metier; // Dossier Metier à importer pour pouvoir utiliser les class défini dedans.

namespace ProjetEntityFrameworkCodeFirst.Dao
{
    public class PersonneContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Adresse> Adresses { get; set; }

        public DbSet<Voiture> Voitures { get; set; }

        public DbSet<Concessionnaire> Concessionnaires { get; set; }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<FormationPersonne> FormationsPersonnes { get; set; }

    }
}
