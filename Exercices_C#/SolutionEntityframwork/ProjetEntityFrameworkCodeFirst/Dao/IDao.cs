using ProjetEntityFrameworkCodeFirst.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEntityFrameworkCodeFirst.Dao
{
    public interface IDao
    {

        Personne AjouterPersonne(Personne p);

        Personne TrouverPersonne(int id);

    }
}
