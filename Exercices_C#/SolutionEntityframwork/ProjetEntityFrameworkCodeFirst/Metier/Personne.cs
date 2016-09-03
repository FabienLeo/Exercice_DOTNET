using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class Personne
    {
        [Key]
        public int idPersonne { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public int Age { get; set; }

        [Index(IsUnique = true), Required, Column("Email", TypeName="varchar")]
        public string Email { get; set; }

        public int idAdresse { get; set; } // Déclaration de la clé étrangère
        public virtual Adresse adresse { get; set; } // Déclaration de l'objet adresse de la Personne ( une personne n'a qu'une adresse )

        public virtual ICollection<Formation> Formations { get; set; }   // Déclaration de la relation ManyToMany avec Personne

        public virtual ICollection<Voiture> Voitures { get; set; }

    }
}
