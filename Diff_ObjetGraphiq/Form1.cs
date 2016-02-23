using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diff_ObjetGraphiq
{
    public partial class Form1 : Form // +++++++++++++++++ Exo: CheckBox & RadioButton ++++++++++++++++++++++++++++++++++
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)//Saisie du texte par l'utilisateur
        {
            if (textBox1.Text != "")
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }

            label2.Text = textBox1.Text;
        }


        private void groupBox1_Enter(object sender, EventArgs e) // Groupe des CheckBox "Choix"++++++++++++++++++++++++++++++++++++
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //CheckBox "Couleur de Fond" 
        {
            groupBox2.Visible = checkBox1.Checked; //Rend le GrpBox des CheckBox Actif ... 
            if (checkBox1.Checked == false)  // Si décoché, les choix sont retirés, le "résultat" aussi
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) //CheckBox "Couleur Caractère"
        {
            groupBox3.Visible = checkBox2.Checked;
            if (checkBox2.Checked == false)
            {
                radioButton6.Checked = false;
                radioButton5.Checked = false;
                radioButton4.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) //CheckBox "Casse" 
        {
            groupBox4.Visible = checkBox3.Checked;
            if (checkBox3.Checked == false)
            {
                radioButton8.Checked = false;
                radioButton7.Checked = false;
            }
        }
        
        private void groupBox2_Enter(object sender, EventArgs e) //Groupe des "Choix de Couleur de Fond"++++++++++++++++++++++++++++
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) // RadioBtn "Fond Rouge"
        {
            if (radioButton1.Checked == true)
            {
                label2.BackColor = Color.OrangeRed;
            }
            else
            {
                label2.BackColor = SystemColors.Control;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) // RadioBtn "Fond Vert"
        {
            if (radioButton2.Checked == true)
            {
                label2.BackColor = Color.YellowGreen;
            }
            else
            {
                label2.BackColor = SystemColors.Control;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) // RadioBtn "Fond Bleu"
        {
            if (radioButton3.Checked == true)
            {
                label2.BackColor = Color.SkyBlue;
            }
            else
            {
                label2.BackColor = SystemColors.Control;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e) // Groupe des "Choix de Couleur de Caractère"+++++++++++++++++++++++++++++++++
        {

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e) //RadioBtn "Caractère Rouge"
        {
            if (radioButton6.Checked == true)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //RadioBtn "Caractère Blanc"
        {
            if (radioButton5.Checked == true)
            {
                label2.ForeColor = Color.White;
            }
            else
            {
                label2.ForeColor = SystemColors.ControlText;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //RadioBtn "Caractère Noir"
        {
            if (radioButton4.Checked == true)
            {
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = SystemColors.ControlText;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e) //Groupe des "Choix de Casse"+++++++++++++++++++++++++++++++++++++
        {

        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e) // "Minuscules"
        {
            if (radioButton8.Checked == true)
            {
                label2.Text = textBox1.Text.ToLower();
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) // "Majuscules"
        {
            if (radioButton7.Checked == true)
            {
                label2.Text = textBox1.Text.ToUpper();
            }
            

        }

        private void label2_Click(object sender, EventArgs e) // Label "RESULTAT" ++++++++++++++++++++++++++++++++++++++++++++
        {

        }

        
    }
}
