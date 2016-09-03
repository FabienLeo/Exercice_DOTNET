using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_Fabien
{
    public partial class FenetrePrincipal : Form
    {

        List<string> Operateur = new List<string>();
        List<string> Nombre = new List<string>();
        int EstResult = 0;


        public FenetrePrincipal()
        {
            InitializeComponent();
        }

        private void Bouton0_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._0_O;
            Bouton0.Image = ImageClick;
            
            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "0";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "0";
            }

        }

        private void Bouton1_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._1_O;
            Bouton1.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "1";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "1";
            }
        }

        private void Bouton2_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._2_O;
            Bouton2.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "2";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "2";
            }
        }

        private void Bouton3_Click(object sender, EventArgs e)
        {

            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._3_O;
            Bouton3.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "3";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "3";
            }
        }

        private void Bouton4_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._4_O;
            Bouton4.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "4";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "4";
            }
        }

        private void Bouton5_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._5_O;
            Bouton5.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "5";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "5";
            }
        }

        private void Bouton6_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._6_O;
            Bouton6.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "6";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "2";
            }
        }

        private void Bouton7_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._7_O;
            Bouton7.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "7";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "7";
            }
        }

        private void Bouton8_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._8_O;
            Bouton8.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "8";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "8";
            }
        }

        private void Bouton9_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources._9_O;
            Bouton9.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "9";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + "9";
            }
        }

        private void BoutonPoint_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Point_O;
            BoutonPoint.Image = ImageClick;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "0,";
            }
            else
            {
                TextBoxSaisie.Text = TextBoxSaisie.Text + ",";
            }
        }


        private void BoutonPlus_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Positif_O;
            BoutonPlus.Image = ImageClick;

            if (EstResult == 1)
            {
                TextBoxOperation.Clear();
                Nombre.Clear();
                Nombre.Add(TextBoxSaisie.Text);
                TextBoxOperation.Text = TextBoxSaisie.Text + "+";
                Operateur.Clear();
                Operateur.Add("+");
                TextBoxSaisie.Text = "0";
                EstResult = 0;
            }
            else
            {
                if (TextBoxSaisie.Text == "0")
                {
                    TextBoxSaisie.Text = "0";
                }
                else
                {
                    TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text + "+";
                    Nombre.Add(TextBoxSaisie.Text);
                    TextBoxSaisie.Text = "0";
                    Operateur.Add("+");
                }
            }
        }

        private void BoutonMoins_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Moins_O;
            BoutonMoins.Image = ImageClick;

            if (EstResult == 1)
            {
                TextBoxOperation.Clear();
                Nombre.Clear();
                Nombre.Add(TextBoxSaisie.Text);
                TextBoxOperation.Text = TextBoxSaisie.Text + "-";
                Operateur.Clear();
                Operateur.Add("-");
                TextBoxSaisie.Text = "0";
                EstResult = 0;
            }
            else
            {
                if (TextBoxSaisie.Text == "0")
                {
                    TextBoxSaisie.Text = "0";
                }
                else
                {
                    TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text + "-";
                    Nombre.Add(TextBoxSaisie.Text);
                    TextBoxSaisie.Text = "0";
                    Operateur.Add("-");
                }
            }

        }

        private void BoutonMulti_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Multi_O;
            BoutonMulti.Image = ImageClick;

            if (EstResult == 1)
            {
                TextBoxOperation.Clear();
                Nombre.Clear();
                Nombre.Add(TextBoxSaisie.Text);
                TextBoxOperation.Text = TextBoxSaisie.Text + "*";
                Operateur.Clear();
                Operateur.Add("*");
                TextBoxSaisie.Text = "0";
                EstResult = 0;
            }
            else
            {
                if (TextBoxSaisie.Text == "0")
                {
                    TextBoxSaisie.Text = "0";
                }
                else
                {
                    TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text + "*";
                    Nombre.Add(TextBoxSaisie.Text);
                    TextBoxSaisie.Text = "0";
                    Operateur.Add("*");
                }
            }

        }

        private void BoutonAC_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.AC_GF;
            BoutonAC.Image = ImageClick;

            TextBoxSaisie.Text = "0";
            TextBoxOperation.Clear();
            Nombre.Clear();
            Operateur.Clear();
        }

        private void BoutonInverse_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Inverse_O;
            BoutonInverse.Image = ImageClick;

            double TextInverse = double.Parse(TextBoxSaisie.Text);
            TextInverse = TextInverse * -1;
            TextBoxSaisie.Text = Convert.ToString(TextInverse);
        }

        private void BoutonPoucent_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Pourcent_O;
            BoutonPoucent.Image = ImageClick;

            if (EstResult == 1)
            {
                TextBoxOperation.Clear();
                Nombre.Clear();
                Nombre.Add(TextBoxSaisie.Text);
                TextBoxOperation.Text = TextBoxSaisie.Text + "%";
                Operateur.Clear();
                Operateur.Add("%");
                TextBoxSaisie.Text = "0";
                EstResult = 0;
            }
            else
            {
                if (TextBoxSaisie.Text == "0")
                {
                    TextBoxSaisie.Text = "0";
                }
                else
                {
                    TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text + "%";
                    Nombre.Add(TextBoxSaisie.Text);
                    TextBoxSaisie.Text = "0";
                    Operateur.Add("%");
                }
            }
        }

        private void BoutonDiviser_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Diviser_O;
            BoutonDiviser.Image = ImageClick;

            if (EstResult == 1)
            {
                TextBoxOperation.Clear();
                Nombre.Clear();
                Nombre.Add(TextBoxSaisie.Text);
                TextBoxOperation.Text = TextBoxSaisie.Text + "/";
                Operateur.Clear();
                Operateur.Add("/");
                TextBoxSaisie.Text = "0";
                EstResult = 0;
            }
            else
            {
                if (TextBoxSaisie.Text == "0")
                {
                    TextBoxSaisie.Text = "0";
                }
                else
                {
                    TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text + "/";
                    Nombre.Add(TextBoxSaisie.Text);
                    TextBoxSaisie.Text = "0";
                    Operateur.Add("/");
                }
            }

        }

        private void BoutonEgal_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap ImageClick = Calculatrice_Fabien.Properties.Resources.Egal_O;
            BoutonEgal.Image = ImageClick;

            double Resultat = 0.00;
            double Nb1 = 0;
            double Nb2 = 0;

            if (TextBoxSaisie.Text == "0")
            {
                TextBoxSaisie.Text = "0";
            }
            else
            {
                TextBoxOperation.Text = TextBoxOperation.Text + TextBoxSaisie.Text;
                Nombre.Add(TextBoxSaisie.Text);
            }

            if (Operateur.Count != 0)
            {
                for (int i = 0; i < (Nombre.Count - 1); i++)
                {
                    if (EstResult == 0)
                    {
                        Nb1 = double.Parse(Nombre[i]);
                    }
                    else
                    {
                        Nb1 = Resultat;
                    }
                    Nb2 = double.Parse(Nombre[i + 1]);
                    string Op = Operateur[i];

                    if (Op == "+")
                    {
                        Resultat = Nb1 + Nb2;
                        EstResult = 1;
                    }

                    if (Op == "-")
                    {
                        Resultat = Nb1 - Nb2;
                        EstResult = 1;
                    }

                    if (Op == "*")
                    {
                        Resultat = Nb1 * Nb2;
                        EstResult = 1;
                    }

                    if (Op == "/")
                    {
                        Resultat = Nb1 / Nb2;
                        EstResult = 1;
                    }

                    if (Op == "%")
                    {
                        Resultat = Nb1 * (Nb2 / 100);
                        EstResult = 1;
                    }

                }
            }
            else
            {
                Resultat = Convert.ToInt32(TextBoxSaisie.Text);
            }           
            TextBoxSaisie.Text = Convert.ToString(Resultat);
            Nombre.Clear();
            Nombre.Add(Convert.ToString(Resultat));
            Operateur.Clear();
            Resultat = 0;

        }


        private void Bouton_MouseEnter(object sender, EventArgs e)
        {
            PictureBox PictureSwitch = (PictureBox)sender;
            switch (PictureSwitch.Name.ToString())
            {
                case "Bouton0":
                    System.Drawing.Bitmap ImageSelect0 = Calculatrice_Fabien.Properties.Resources._0_GF;
                    Bouton0.Image = ImageSelect0;
                    break;
                case "Bouton1":
                    System.Drawing.Bitmap ImageSelect1 = Calculatrice_Fabien.Properties.Resources._1_GF;
                    Bouton1.Image = ImageSelect1;
                    break;
                case "Bouton2":
                    System.Drawing.Bitmap ImageSelect2 = Calculatrice_Fabien.Properties.Resources._2_GF;
                    Bouton2.Image = ImageSelect2;
                    break;
                case "Bouton3":
                    System.Drawing.Bitmap ImageSelect3 = Calculatrice_Fabien.Properties.Resources._3_GF;
                    Bouton3.Image = ImageSelect3;
                    break;
                case "Bouton4":
                    System.Drawing.Bitmap ImageSelect4 = Calculatrice_Fabien.Properties.Resources._4_GF;
                    Bouton4.Image = ImageSelect4;
                    break;
                case "Bouton5":
                    System.Drawing.Bitmap ImageSelect5 = Calculatrice_Fabien.Properties.Resources._5_GF;
                    Bouton5.Image = ImageSelect5;
                    break;
                case "Bouton6":
                    System.Drawing.Bitmap ImageSelect6 = Calculatrice_Fabien.Properties.Resources._6_GF;
                    Bouton6.Image = ImageSelect6;
                    break;
                case "Bouton7":
                    System.Drawing.Bitmap ImageSelect7 = Calculatrice_Fabien.Properties.Resources._7_GF;
                    Bouton7.Image = ImageSelect7;
                    break;
                case "Bouton8":
                    System.Drawing.Bitmap ImageSelect8 = Calculatrice_Fabien.Properties.Resources._8_GF;
                    Bouton8.Image = ImageSelect8;
                    break;
                case "Bouton9":
                    System.Drawing.Bitmap ImageSelect9 = Calculatrice_Fabien.Properties.Resources._9_GF;
                    Bouton9.Image = ImageSelect9;
                    break;
                case "BoutonPoint":
                    System.Drawing.Bitmap ImageSelectPoint = Calculatrice_Fabien.Properties.Resources.Point_GF;
                    BoutonPoint.Image = ImageSelectPoint;
                    break;
                case "BoutonEgal":
                    System.Drawing.Bitmap ImageSelectEgal = Calculatrice_Fabien.Properties.Resources.Egal_GC;
                    BoutonEgal.Image = ImageSelectEgal;
                    break;
                case "BoutonPlus":
                    System.Drawing.Bitmap ImageSelectPlus = Calculatrice_Fabien.Properties.Resources.Positif_GC;
                    BoutonPlus.Image = ImageSelectPlus;
                    break;
                case "BoutonMoins":
                    System.Drawing.Bitmap ImageSelectMoins = Calculatrice_Fabien.Properties.Resources.Moins_GC;
                    BoutonMoins.Image = ImageSelectMoins;
                    break;
                case "BoutonMulti":
                    System.Drawing.Bitmap ImageSelectMulti = Calculatrice_Fabien.Properties.Resources.Multi_GC;
                    BoutonMulti.Image = ImageSelectMulti;
                    break;
                case "BoutonDiviser" :
                    System.Drawing.Bitmap ImageSelectDiviser = Calculatrice_Fabien.Properties.Resources.Diviser_GC;
                    BoutonDiviser.Image = ImageSelectDiviser;
                    break;
                case "BoutonPoucent":
                    System.Drawing.Bitmap ImageSelectPourcent = Calculatrice_Fabien.Properties.Resources.Pourcent_GC;
                    BoutonPoucent.Image = ImageSelectPourcent;
                    break;
                case "BoutonInverse":
                    System.Drawing.Bitmap ImageSelectInverse = Calculatrice_Fabien.Properties.Resources.Inverse_GC;
                    BoutonInverse.Image = ImageSelectInverse;
                    break;
                case "BoutonAC":
                    System.Drawing.Bitmap ImageSelectAC = Calculatrice_Fabien.Properties.Resources.AC_GF;
                    BoutonAC.Image = ImageSelectAC;
                    break;
                default:
                    break;
            }

        }

        private void Bouton_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureSwitch = (PictureBox)sender;
            switch (PictureSwitch.Name.ToString())
            {
                case "Bouton0":
                    System.Drawing.Bitmap ImageLeave0 = Calculatrice_Fabien.Properties.Resources._0_GC;
                    Bouton0.Image = ImageLeave0;
                    break;
                case "Bouton1":
                    System.Drawing.Bitmap ImageLeave1 = Calculatrice_Fabien.Properties.Resources._1_GC;
                    Bouton1.Image = ImageLeave1;
                    break;
                case "Bouton2":
                    System.Drawing.Bitmap ImageLeave2 = Calculatrice_Fabien.Properties.Resources._2_GC;
                    Bouton2.Image = ImageLeave2;
                    break;
                case "Bouton3":
                    System.Drawing.Bitmap ImageLeave3 = Calculatrice_Fabien.Properties.Resources._3_GC;
                    Bouton3.Image = ImageLeave3;
                    break;
                case "Bouton4":
                    System.Drawing.Bitmap ImageLeave4 = Calculatrice_Fabien.Properties.Resources._4_GC;
                    Bouton4.Image = ImageLeave4;
                    break;
                case "Bouton5":
                    System.Drawing.Bitmap ImageLeave5 = Calculatrice_Fabien.Properties.Resources._5_GC;
                    Bouton5.Image = ImageLeave5;
                    break;
                case "Bouton6":
                    System.Drawing.Bitmap ImageLeave6 = Calculatrice_Fabien.Properties.Resources._6_GC;
                    Bouton6.Image = ImageLeave6;
                    break;
                case "Bouton7":
                    System.Drawing.Bitmap ImageLeave7 = Calculatrice_Fabien.Properties.Resources._7_GC;
                    Bouton7.Image = ImageLeave7;
                    break;
                case "Bouton8":
                    System.Drawing.Bitmap ImageLeave8 = Calculatrice_Fabien.Properties.Resources._8_GC;
                    Bouton8.Image = ImageLeave8;
                    break;
                case "Bouton9":
                    System.Drawing.Bitmap ImageLeave9 = Calculatrice_Fabien.Properties.Resources._9_GC;
                    Bouton9.Image = ImageLeave9;
                    break;
                case "BoutonPoint":
                    System.Drawing.Bitmap ImageLeavePoint = Calculatrice_Fabien.Properties.Resources.Point_GC;
                    BoutonPoint.Image = ImageLeavePoint;
                    break;
                case "BoutonEgal":
                    System.Drawing.Bitmap ImageLeaveEgal = Calculatrice_Fabien.Properties.Resources.Egal_GF;
                    BoutonEgal.Image = ImageLeaveEgal;
                    break;
                case "BoutonPlus":
                    System.Drawing.Bitmap ImageLeavePlus = Calculatrice_Fabien.Properties.Resources.Positif_GF;
                    BoutonPlus.Image = ImageLeavePlus;
                    break;
                case "BoutonMoins":
                    System.Drawing.Bitmap ImageLeaveMoins = Calculatrice_Fabien.Properties.Resources.Moins_GF;
                    BoutonMoins.Image = ImageLeaveMoins;
                    break;
                case "BoutonMulti":
                    System.Drawing.Bitmap ImageLeaveMulti = Calculatrice_Fabien.Properties.Resources.Multi_GF;
                    BoutonMulti.Image = ImageLeaveMulti;
                    break;
                case "BoutonDiviser":
                    System.Drawing.Bitmap ImageLeaveDiviser = Calculatrice_Fabien.Properties.Resources.Diviser_GF;
                    BoutonDiviser.Image = ImageLeaveDiviser;
                    break;
                case "BoutonPoucent":
                    System.Drawing.Bitmap ImageLeavePourcent = Calculatrice_Fabien.Properties.Resources.Pourcent_GF;
                    BoutonPoucent.Image = ImageLeavePourcent;
                    break;
                case "BoutonInverse":
                    System.Drawing.Bitmap ImageLeaveInverse = Calculatrice_Fabien.Properties.Resources.Inverse_GF;
                    BoutonInverse.Image = ImageLeaveInverse;
                    break;
                case "BoutonAC":
                    System.Drawing.Bitmap ImageLeaveAC = Calculatrice_Fabien.Properties.Resources.AC_O;
                    BoutonAC.Image = ImageLeaveAC;
                    break;
                default:
                    break;
            }

        }

    }

}
