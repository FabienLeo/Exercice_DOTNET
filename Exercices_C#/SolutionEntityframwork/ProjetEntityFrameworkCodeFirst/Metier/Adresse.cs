using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class Adresse
    {
        [Key]
        public int idAdresse { get; set; }

        [Required]
        public string NomRue { get; set; }

        [Required]
        public string CodePostale { get; set; }

        [Required]
        public string Ville { get; set; }

        [Required]
        public string Pays { get; set; }

        public virtual ICollection<Personne> Personnes { get; set; }    // Déclaration de la collection de personne habitant à cette adresse

    }
}
