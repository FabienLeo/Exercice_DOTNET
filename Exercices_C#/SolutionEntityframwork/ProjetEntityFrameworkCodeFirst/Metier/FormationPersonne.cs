using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Metier
{
    public class FormationPersonne 
    {

        [Key, Column(Order=0)]
        public int idFormation { get; set; }
        [Key, Column(Order = 1)]
        public int idPersonne { get; set; }

        public virtual Formation Formation { get; set;}
        public virtual Personne Personne { get; set;}

        public int Something { get; set; }

        public string SomeThingElse { get; set; }


    }
}
