using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Op_sur_ListBox
{
    public partial class Form1 : Form // +++++++++++++++++  Exo: Op sur ListBox & leurs Propriétés ++++++++++++++++++++++++++++++++++
    {
        public Form1()
        {
            InitializeComponent();
        }
        //+++++++++++++++++ Groupe "NOUVEL ELEMENT" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button1_Click(object sender, EventArgs e) //Btn "Ajout Liste"
        {
            if (textBox1.Text == (string)listBox1.SelectedItem)
            {
                MessageBox.Show("Cet élément est déjà présent", "Erreur");
                textBox1.Text = ""; // Vide la textBox après chaque ajout
                textBox1.Focus(); // redonne le focus à la textBox 
            }
            else
            {
                listBox1.Items.Add(textBox1.Text); //Ajoute le texte dans la listBox
                textBox1.Text = ""; // Vide la textBox après chaque ajout
                textBox1.Focus(); // redonne le focus à la textBox 
            }

            
        }

        //+++++++++++++++++ Groupe "LstListe" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Affiche la Liste des Items... 
        {
            textBox5.Text = (string)listBox1.SelectedItem; //Affiche le texte de l'Item séléctionné dans textBox5
            textBox4.Text = listBox1.SelectedIndex.ToString(); // Affiche le N° d'index de l'Item séléctionné
            textBox3.Text = Convert.ToString(listBox1.Items.Count); //Affiche le nombre totale d'Items
        }

        //+++++++++++++++++ Groupe "PROPRIETES" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void textBox3_TextChanged(object sender, EventArgs e) //Affiche le Nbre d'Items de la Liste
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //Affiche le N° de l'Item séléctionné
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //Affiche le texte de l'Item séléctionné
        {
            
        }

        //+++++++++++++++++ Groupe "INDEX ELEMENT" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button2_Click(object sender, EventArgs e) //Btn "Sélectionner"
        {
            //listBox1.SelectedIndex = Convert.ToInt32(textBox2.Text);//"Séléctionne" l'item dans ListBox, pour le N° d'index demandé

            if (Convert.ToInt32(textBox2.Text) > (listBox1.Items.Count-1)) //Vérifie que l'index demandé n'est pas plus grand que le nbre d'items
            {
                textBox2.Clear();
                textBox2.Focus();
                MessageBox.Show("N'existe pas !!!", "ERREUR");
            }
            else
            {
                listBox1.SelectedIndex = Convert.ToInt32(textBox2.Text);//"Séléctionne" l'item dans ListBox, pour le N° d'index demandé
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Saisie "Index Elément"
        {
            
        }

        private void button3_Click(object sender, EventArgs e) // Btn "Vider la liste"
        {
            listBox1.Items.Clear();
        }
    }
}
