using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class FormationIntra : Formation
    {
        [Required]
        public string NomEntreprise { get; set; }

    }
}
