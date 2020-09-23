using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier2_Chaine_de_Caracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int indice =(int)numericUpDown1.Value;
            string text = textBox1.Text;
            int longueur = textBox1.TextLength;

            if (indice > longueur || text == string.Empty) 
            {
                MessageBox.Show("L'indice choisi est supérieur au nombre de caractères", "Erreur!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);              
            }
            
            
            else
            {
                if (char.IsLetter(text[indice])) { textBox3.Text = "C'est une lettre!"; }
                if (char.IsDigit(text[indice])) { textBox3.Text = "C'est un chiffre!"; }
                if (!char.IsLetter(text[indice]) && !char.IsDigit(text[indice])) { textBox3.Text = "C'est un caractère spécial!"; }
            }
           
        }
    }
}
