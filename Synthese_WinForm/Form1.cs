using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Synthese_WinForm
{
    public partial class Form1 : Form // +++++++++++++++++ Exo: Synthèse : Emprunts ++++++++++++++++++++++++++++++++++
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedItem = "Mensuelle";
            hScrollBar1.Value = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Capital Emprunté
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) //ScrollBar Durée Remboursement en Mois
        {

        }
        private void hScrollBar1_ValueChanged(object sender, EventArgs e) //Lorsque Scrollbar bouge, change de valeur
        {
            double n = 0;

            if (listBox1.SelectedItem == "Mensuelle") 
            {
                hScrollBar1.SmallChange = 1; // taille mini du "curseur"
                hScrollBar1.LargeChange = 10; // taille maxi du "curseur"
                hScrollBar1.Minimum = 0; // Départ des valeurs du scrollbar
                hScrollBar1.Maximum = 209; // Longueur max du scrollbar
                n = hScrollBar1.Value;
                hScrollBar1.Value = (hScrollBar1.Value / 1) * 1;
                label4.Text = hScrollBar1.Value.ToString();
                
            }

            if (listBox1.SelectedItem == "Bimestrielle")
            {
                hScrollBar1.SmallChange = 2;
                hScrollBar1.LargeChange = 20;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 219;
                n = (hScrollBar1.Value / 2); // valeur su scrollbar divisé par le "type" de remboursement, ici tous les 2 mois 
                hScrollBar1.Value = (hScrollBar1.Value / 2) * 2; //Divisé puis multiplié la valeur afin de garder un nombre entier juste
                label4.Text = hScrollBar1.Value.ToString();

            }

            if (listBox1.SelectedItem == "Trimestrielle")
            {
                hScrollBar1.SmallChange = 3;
                hScrollBar1.LargeChange = 30;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 229;
                n = (hScrollBar1.Value / 3);
                hScrollBar1.Value = (hScrollBar1.Value / 3) * 3;
                label4.Text = hScrollBar1.Value.ToString();

            }

            if (listBox1.SelectedItem == "Semestrielle")
            {
                hScrollBar1.SmallChange = 6;
                hScrollBar1.LargeChange = 60;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 259;
                n = (hScrollBar1.Value / 6);
                hScrollBar1.Value = (hScrollBar1.Value / 6) * 6;
                label4.Text = hScrollBar1.Value.ToString();

            }

            if (listBox1.SelectedItem == "Annuelle")
            {
                hScrollBar1.SmallChange = 12;
                hScrollBar1.LargeChange = 120;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 319;
                n = hScrollBar1.Value/12;
                hScrollBar1.Value = (hScrollBar1.Value / 12) * 12;
                label4.Text = hScrollBar1.Value.ToString();
            }

            label6.Text = n.ToString();
            
        }
        private void label4_Click(object sender, EventArgs e) // Affichage Durée Remboursement en Mois
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //ListBox "Périodicité Remboursement"
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //RadioBtn " 7 % "
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //RadioBtn " 8 % "
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //RadioBtn " 9 % "
        {

        }

        private void label6_Click(object sender, EventArgs e) //Affichage "Nombre de Remboursements"
        {

        }

        private void label8_Click(object sender, EventArgs e) // Affichage "Montant des Remboursements"
        {

        }

        private void Btn_Annuler_Click(object sender, EventArgs e) // Btn "Annuler"
        {

        }

        private void btnCalcul_Click(object sender, EventArgs e) // Btn " OK "
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Erreur de Capital", "Erreur");
            }
            else
            {
                double k = Convert.ToInt32(textBox2.Text);
                double T7 = 0.07; // RadioBtn 1
                double T8 = 0.08; // RadioBtn 2
                double T9 = 0.09; // RadioBtn 3
                double n = Convert.ToInt32(label6.Text);
                double Result = 0;

                if (listBox1.SelectedItem == "Mensuelle")
                {
                    if (radioButton1.Checked == true)
                    {
                        Result = ((k * (T7 / 12)) / (1 - Math.Pow((1 + T7 / 12), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        Result = ((k * (T8 / 12)) / (1 - Math.Pow((1 + T8 / 12), (-n))));
                    }
                    if (radioButton3.Checked == true)
                    {
                        Result = ((k * (T9 / 12)) / (1 - Math.Pow((1 + T9 / 12), (-n))));
                    }
                }
                if (listBox1.SelectedItem == "Bimestrielle")
                {
                    if (radioButton1.Checked == true)
                    {
                        Result = ((k * (T7 / 6)) / (1 - Math.Pow((1 + T7 / 6), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        Result = ((k * (T8 / 6)) / (1 - Math.Pow((1 + T8 / 6), (-n))));
                    }
                    if (radioButton3.Checked == true)
                    {
                        Result = ((k * (T9 / 6)) / (1 - Math.Pow((1 + T9 / 6), (-n))));
                    }
                }
                if (listBox1.SelectedItem == "Trimestrielle")
                {
                    if (radioButton1.Checked == true)
                    {
                        Result = ((k * (T7 / 4)) / (1 - Math.Pow((1 + T7 / 4), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        Result = ((k * (T8 / 4)) / (1 - Math.Pow((1 + T8 / 4), (-n))));
                    }
                    if (radioButton3.Checked == true)
                    {
                        Result = ((k * (T9 / 4)) / (1 - Math.Pow((1 + T9 / 4), (-n))));
                    }
                }
                if (listBox1.SelectedItem == "Semestrielle")
                {
                    if (radioButton1.Checked == true)
                    {
                        Result = ((k * (T7 / 2)) / (1 - Math.Pow((1 + T7 / 2), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        Result = ((k * (T8 / 2)) / (1 - Math.Pow((1 + T8 / 2), (-n))));
                    }
                    if (radioButton3.Checked == true)
                    {
                        Result = ((k * (T9 / 2)) / (1 - Math.Pow((1 + T9 / 2), (-n))));
                    }
                }
                if (listBox1.SelectedItem == "Annuelle")
                {
                    if (radioButton1.Checked == true)
                    {
                        Result = ((k * T7) / (1 - Math.Pow((1 + T7), (-n))));
                    }
                    if (radioButton2.Checked == true)
                    {
                        Result = ((k * T8) / (1 - Math.Pow((1 + T8), (-n))));
                    }
                    if (radioButton3.Checked == true)
                    {
                        Result = ((k * T9) / (1 - Math.Pow((1 + T9), (-n))));
                    }
                }

                label8.Text = Result.ToString();

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Regex TxtNom = new Regex(@"^[a-zA-Z]$");//Contrôle pour n'accepter que des caractères

            if (TxtNom.IsMatch(txtName.Text)) //Affichera la TextBox en vert si Ok, sinon en rouge + Beep sonore
            {
                txtName.BackColor = Color.LightGreen;
            }
            else
            {
                txtName.BackColor = Color.Red;
                Console.Beep(300, 800);
            }
        }
    }
}
