using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // à rajouter pour utiliser les Regex

namespace Valid_Saisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //private static new void FormClosed()
        //{
        //    throw new NotImplementedException();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e) // Nom
        {
            Regex TxtNom = new Regex(@"^[a-zA-Z]{1,30}$");//Contrôle pour n'accepter que des caractères, 30 max.

            if (TxtNom.IsMatch(textBox1.Text)) //Affichera la TextBox en vert si Ok, sinon en rouge
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                Console.Beep(300, 800);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Date
        {
            Regex TxtDate = new Regex(@"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");//contrôle Date
            if (TxtDate.IsMatch(textBox2.Text)) //Affichera la TextBox en vert si Ok, sinon en rouge
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Console.Beep(300, 800);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)// Montant
        {
            Regex TxtMontant = new Regex(@"^[0-9]+(,|.[0-9]+)?$");
            if (TxtMontant.IsMatch(textBox3.Text)) //Affichera la TextBox en vert si Ok, sinon en rouge
            {
                textBox3.BackColor = Color.LightGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                Console.Beep(300, 800);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) // Code Postal
        {
            Regex TxtCP = new Regex(@"^[0-9]{5}$");
            if (TxtCP.IsMatch(textBox4.Text)) //Affichera la TextBox en vert si Ok, sinon en rouge
            {
                textBox4.BackColor = Color.LightGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Console.Beep(300, 800);
            }
        }

        private void button1_Click(object sender, EventArgs e) //btn Valider : Pop Up de Validation avec affichage des données récupérées dans les TextBox
        {
            MessageBox.Show("Nom : "+ textBox1.Text +"\n" 
                            +"Date : "+ textBox2.Text +"\n"
                            + "Montant : "+ textBox3.Text +"\n"
                            +"Code : "+ textBox4.Text, "Validation effectuée", MessageBoxButtons.OK);
            DialogResult dr = MessageBox.Show("Fin de l’application ?", "FIN",MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                        Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e) // btn Effacer
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Fin de l’application ?", "FIN", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr2 == DialogResult.No)
            {
                e.Cancel = true;
            }
            
            
                
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex TxtNom = new Regex(@"^[a-zA-Z]{1,30}$");

            if (TxtNom.IsMatch(textBox1.Text)) 
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                Console.Beep(300, 800);
                e.Cancel = true;
                MessageBox.Show("Erreur de Saisie");
            }
        }
    }
}
