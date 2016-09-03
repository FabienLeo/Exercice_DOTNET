using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompteLibrary;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des deux comptes
            Epargne MonCompte = new Epargne();
            Epargne MonCompte2 = new Epargne();
            ComptePayant MonComptePayant = new ComptePayant();

            //Création des varaibles locales temporaire pour les conditin "if"
            String TmpNum = "0";
            double TmpMontant = 0.00;

            // Permet de créer un point d'acces pour la fonction "goto"
            CHOIX:

            // Affichage des information des comptes
            Console.WriteLine("le code numéro : " + MonCompte.Code + " , le solde est de : " + MonCompte.Solde);
            Console.WriteLine("le code numéro : " + MonCompte2.Code + " , le solde est de : " + MonCompte2.Solde);
            Console.WriteLine("le code numéro : " + MonComptePayant.Code + " , le solde est de : " + MonComptePayant.Solde + " \n\n");


            // Question posée à l'utilisateur, on récupère la valmeur de la touche appuyé
            Console.WriteLine("Quel type d'opération voulez faire sur vos compte ? \n ( \"d\" pour Déposer ou \"r\" pour Retirer ou \"q\" pour quitter) \n");
            ConsoleKeyInfo Op = Console.ReadKey(true);

            // On test la valeur de la touche afin de savoir quoi faire
            if (Op.Key == ConsoleKey.D)
            {
                Console.WriteLine("Quel est le numéro du compte voulez vous créditer ?");
                TmpNum = Convert.ToString(Console.ReadLine());
            }

            // On test la valeur de la touche afin de savoir quoi faire
            if (Op.Key == ConsoleKey.R)
            {
                Console.WriteLine("Quel est le numéro du compte voulez vous débiter ?");
                TmpNum = Convert.ToString(Console.ReadLine());
            }

            // On test la valeur de la touche afin de savoir quoi faire
            if (Op.Key == ConsoleKey.Q)
            {
                goto FINISH;
            }

            // On test la valeur du numero de compte entrée afin de savoir s'il existe ?
            if (TmpNum == MonCompte.Code)
            {
                Console.WriteLine("Montant de l'opération pour le compte numéro " + TmpNum + ":");
                TmpMontant = Convert.ToDouble(Console.ReadLine());
                if (Op.Key == ConsoleKey.D) 
                {
                    MonCompte.Depot(TmpMontant);
                }
                if (Op.Key == ConsoleKey.R)
                {
                    MonCompte.Retirer(TmpMontant);
                }
            }

            // On test la valeur du numero de compte entrée afin de savoir s'il existe ?
            if (TmpNum == MonCompte2.Code)
            {
                Console.WriteLine("Montant de l'opération pour le compte numéro " + TmpNum + ":");
                TmpMontant = Convert.ToDouble(Console.ReadLine());
                if (Op.Key == ConsoleKey.D)
                {
                    MonCompte2.Depot(TmpMontant);
                }
                if (Op.Key == ConsoleKey.R)
                {
                    MonCompte2.Retirer(TmpMontant);
                }
                
            }
             
            // On test la valeur du numero de compte entrée afin de savoir s'il existe ?
            if (TmpNum == MonComptePayant.Code)
            {
                Console.WriteLine("Montant de l'opération pour le compte numéro " + TmpNum + ":");
                TmpMontant = Convert.ToDouble(Console.ReadLine());
                if (Op.Key == ConsoleKey.D)
                {
                    MonComptePayant.Depot(TmpMontant);
                }
                if (Op.Key == ConsoleKey.R)
                {
                    MonComptePayant.Retirer(TmpMontant);
                }

            }


            // On retour au champ CHOIX ( en début de code
            Console.Clear();
            goto CHOIX;
            
            // Label pour cloturer le programme ( fonction goto )
            FINISH :
            
            Console.WriteLine("AU REVOIR !!!!");
            Console.WriteLine("Press any Key to Quit...");
            Console.ReadKey();


        }
    }
}
