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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Btn "Ajout Liste"
        {
            listBox1.Items.Add(textBox1.Text); //Ajoute le texte dans la listBox
            textBox1.Text = ""; // Vide la textBox après chaque ajout
            textBox1.Focus(); // redonne le focus à la textBox 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Affiche la Liste des Items... 
        {
            textBox5.Text = (string)listBox1.SelectedItem; //Affiche le texte de l'Item séléctionné dans textBox5
            textBox4.Text = listBox1.SelectedIndex.ToString();
            textBox3.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //Affiche le Nbre d'Items de la Liste
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //Affiche le N° de l'Item séléctionné
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //Affiche le texte de l'Item séléctionné
        {
            
        }
    }
}
