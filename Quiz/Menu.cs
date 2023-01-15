using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Quiz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            label1.BackColor = Color.SteelBlue;
            label2.BackColor = Color.SteelBlue;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.CornflowerBlue;
            label1.BackColor = Color.CornflowerBlue;
            label2.BackColor = Color.CornflowerBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy został wybrany poziom trudności
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać poziom trudności! ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie czy została wybrana kategoria pytań
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać kategorię pytań!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Proszę wpisz swoje imię!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
