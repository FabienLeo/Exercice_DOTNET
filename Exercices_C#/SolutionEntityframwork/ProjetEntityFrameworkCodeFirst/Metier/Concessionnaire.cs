using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class Concessionnaire
    {
        [Key]
        public int idConcessionnaire { get; set; }

        [Required]
        public string NomConcessionnaire { get; set; }

        public virtual ICollection<Voiture> Voitures { get; set; }

    }
}
