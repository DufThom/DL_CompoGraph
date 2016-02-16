using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class Additionneur : Form
    {
        int Somme = 0;
        public Additionneur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Bouton 0
        {
            textBox1.Text += "0 +";
            Somme += 0;
        }

        private void button2_Click(object sender, EventArgs e)// Bouton 1
        {
            textBox1.Text += "1+";
            Somme += 1;
        }

        private void button3_Click(object sender, EventArgs e)// Bouton 2
        {
            textBox1.Text += "2+";
            Somme += 2;
        }

        private void button4_Click(object sender, EventArgs e)// Bouton 3
        {
            textBox1.Text += "3+";
            Somme += 3;
        }

        private void button5_Click(object sender, EventArgs e)// Bouton 4
        {
            textBox1.Text += "4+";
            Somme += 4;
        }

        private void button6_Click(object sender, EventArgs e)// Bouton 5
        {
            textBox1.Text += "5+";
            Somme += 5;
        }

        private void button7_Click(object sender, EventArgs e)// Bouton 6
        {
            textBox1.Text += "6+";
            Somme += 6;
        }

        private void button8_Click(object sender, EventArgs e)// Bouton 7
        {
            textBox1.Text += "7+";
            Somme += 7;
        }

        private void button9_Click(object sender, EventArgs e)// Bouton 8
        {
            textBox1.Text += "8+";
            Somme += 8;
        }

        private void button10_Click(object sender, EventArgs e)// Bouton 9
        {
            textBox1.Text += "9+";
            Somme += 9;
        }

        private void button11_Click(object sender, EventArgs e)// Bouton Vider
        {
           textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)// Bouton Calculer
        {
            textBox1.Text += " = " + Somme + " + ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)// Zone Texte
        {

        }
    }
}
