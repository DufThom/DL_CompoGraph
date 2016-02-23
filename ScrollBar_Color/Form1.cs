using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar_Color
{
    public partial class Form1 : Form // +++++++++++++++++ Exo: ScrollBar en Couleurs ++++++++++++++++++++++++++++++++++
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) // ScrollBar "ROUGE"+++++++++++++++++++++++++++++++
        {

        }
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = hScrollBar1.Value.ToString(); //Affiche la valeur, qui s'affiche dans label4, quand on bouge la ScrollBar
            numericUpDown1.Value = hScrollBar1.Value; // idem dans le NumUpDown
            label4.BackColor = Color.FromArgb(hScrollBar1.Value, 0, 0); //change le niveau de Rouge quand on bouge la ScrollBar
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value); // Change le mélange de couleur dans le Label "Resultat"

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e) // ScrollBar "VERT"++++++++++++++++++++++++++++++++
        {

        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = hScrollBar2.Value.ToString();
            numericUpDown2.Value = hScrollBar2.Value;
            label5.BackColor = Color.FromArgb(0, hScrollBar2.Value, 0);
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e) // ScrollBar "BLEU"+++++++++++++++++++++++++++++++++
        {

        }
        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = hScrollBar3.Value.ToString();
            numericUpDown3.Value = hScrollBar3.Value;
            label6.BackColor = Color.FromArgb(0, 0, hScrollBar3.Value);
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //NumUpDown Rouge
        {
            hScrollBar1.Value = (int)numericUpDown1.Value; //change la position de ScrollBar quand on change la valeur du NumUpDown
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //NumUpDown Vert
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) //NumUpDown Bleu
        {

        }

        private void label4_Click(object sender, EventArgs e) //Label "Rouge"
        {

        }

        private void label5_Click(object sender, EventArgs e) //Label "Vert"
        {

        }
        private void label6_Click(object sender, EventArgs e) //Label "Bleu"
        {

        }

        private void label7_Click(object sender, EventArgs e) // Label "RESULTAT"
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
