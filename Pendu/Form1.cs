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
            DejaEntrer.Text = "";
            MotCacher.Text = "";
        }
        string mot = "";
        string savedChar = "";

        char[] triedList = new char[11];
        int nextIndex = 0;
        int tries = 0;

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

        // Entering the word
        private void button1_Click(object sender, EventArgs e)
        {
            // Par exemple, le mot saisi doit avoir une taille
            // maximum(15 caractères, cela parait bien)

            mot = textMot.Text;
            textMot.Text = "";
            MotCacher.Text = CacherMontrer(mot);
        }

        
        private void btnDeviner_Click(object sender, EventArgs e)
        {
            bool atLeastOne = false;
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

                    // Show congradulation message
                    MotCacher.Text = CacherMontrer(mot);
                    atLeastOne = true;
                }
            }

            

            if (!atLeastOne)
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu" + tries);
                tries++;
            }

            DejaEntrer.Text += "," + char.Parse(TextDeviner.Text);
            

            if (nextIndex < triedList.Length)
            {
                triedList[nextIndex] = char.Parse(TextDeviner.Text);
                nextIndex++;
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
    }
}
