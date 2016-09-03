using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class Formation
    {

        [Key]
        public int idFormation { get; set; }

        [Required]
        public string NomFormation { get; set; }

        [Column("Prix", TypeName = "Money"), Required]
        public decimal Prix { get; set; }

        public virtual ICollection<Personne> Personnes { get; set; } // Déclaration de la relation ManyToMany avec Personne

    }
}
