using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Pendu.Properties.Resources.pendu0;
            btnDeviner.Enabled = false;
            TextDeviner.Enabled = false;
            DejaEntrer.Text = "";
            MotCacher.Text = "";
            textEreur.Text = "";
            winText.Text = "";
        }
        string mot = "";
        
        string savedChar = "";

        char[] triedList = new char[11];
        int nextIndex = 0;
        int tries = 0;

        /// <summary>
        ///     
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        string CacherMontrer(string mot)
        {
            string motCacher = "";
            for (int i = 0; i < mot.Length; i++)
            {
                if (!savedChar.Contains(mot[i].ToString())) 
                { 
                    motCacher += "-"; 
                } else
                {
                    motCacher += mot[i];
                }
            }

            return motCacher;
        }

        // a function that checks if player won or not

        bool gagner()
        {
            return mot.ToLower().All(c => savedChar.ToLower().Contains(c));
        }

        // Entering the word
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             *  le mot saisi doit avoir une taille maximum (15 caractères, cela parait bien) et 
             *  doit être contrôlé au niveau du contenu (rien d'autre que des lettres, et non accentuées)
             */

            // valider le mot
            mot = textMot.Text.ToLower();

            if (mot.Length < 15 && mot.Length > 0 && mot.All(char.IsLetter))
            {
                MotCacher.Text = CacherMontrer(mot);
                textMot.Text = "";
                textMot.Enabled = false;
                btnMot.Enabled = false;
                btnDeviner.Enabled = false;
                TextDeviner.Enabled = true;

            } else
            {
                textEreur.Text = "Entrez un mot Valide";
            }

        }

        // ================================================
        // 
        // Function principale qui fait fonctioner le jeux
        //
        // ================================================
        private void btnDeviner_Click(object sender, EventArgs e)
        {
            bool atLeastOne = false;

            if (tries >= 9)
            {
                pictureBox1.Image = Pendu.Properties.Resources.pendu0;
                btnDeviner.Enabled = false;
                TextDeviner.Enabled = false;
                DejaEntrer.Text = "";
                MotCacher.Text = "";
                textEreur.Text = "";
            }

            // verifier si le character entrer est dans la list
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == char.Parse(TextDeviner.Text))
                {
                    savedChar += mot[i].ToString();

                    if (nextIndex < triedList.Length)
                    {
                        triedList[nextIndex] = mot[i];
                        nextIndex++;
                    }

                    MotCacher.Text = CacherMontrer(mot);
                    atLeastOne = true;
                }
            }


            if (!atLeastOne)
            {
                tries++;
                pictureBox1.Image = pictureBox1.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("pendu" + tries);
            }

            DejaEntrer.Text += char.Parse(TextDeviner.Text) + ", ";
            

            if (nextIndex < triedList.Length)
            {
                triedList[nextIndex] = char.Parse(TextDeviner.Text.ToLower());
                nextIndex++;
            }

            TextDeviner.Text = "";

            if (gagner())
            {
                pictureBox1.Image = Pendu.Properties.Resources.pendu0;
                btnDeviner.Enabled = false;
                TextDeviner.Enabled = false;
                DejaEntrer.Text = "";
                MotCacher.Text = "";
                textEreur.Text = "";
            }
        }


        // Re-add empty event handlers removed earlier so designer event wiring compiles.
        // These are intentionally no-ops; the UI labels used them but no behavior is required.
        private void label1_Click(object sender, EventArgs e)
        {
            // Intentionally left blank.
        }

        private void MotCacher_Click(object sender, EventArgs e)
        {
            // Intentionally left blank.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextDeviner_TextChanged(object sender, EventArgs e)
        {
            bool alreadyTried = false;

            try
            {
                string text = TextDeviner.Text.ToLower();
                // validate that the text entered is a 
                // Check if we already tried that letter
                for (int i = 0; i < triedList.Length; i++)
                {
                    if (!text.All(char.IsLetter) || triedList[i] == char.Parse(text))
                    {
                        alreadyTried = true;
                        return;
                    }
                }

                // enable the Enter button if not tried yet
                if (!alreadyTried)
                {
                    btnDeviner.Enabled = true;
                }

            } catch
            {
                btnDeviner.Enabled = false;
            }
        }
    }
}
