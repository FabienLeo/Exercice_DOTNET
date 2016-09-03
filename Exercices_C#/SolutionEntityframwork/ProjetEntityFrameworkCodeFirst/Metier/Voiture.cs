using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class Voiture
    {
        [Key]
        public int idVoiture { get; set; }

        [Required]
        public string Couleur { get; set; }

        [Required]
        public int NbPorte { get; set; }

        public int idPersonne { get; set; } // Déclaration de la clé étrangère

        public virtual Personne personne { get; set; }

        public int idConcessionnaire { get; set; } // Déclaration de la clé étrangère

        public virtual Concessionnaire Concessionnaire { get; set; }

    }
}
