using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             Para poder crear una pestaña creas como una clase pero en vez de una clase un Wndows Form 
            */
            Bitmap img = new Bitmap(Application.StartupPath + @"/img/fondo2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form3();
            formulario3.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form4();
            formulario4.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario5 = new Form5();
            formulario5.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario6 = new Form6();
            formulario6.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario7 = new Form7();
            formulario7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario8 = new Form8();
            formulario8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario9 = new Form9();
            formulario9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario10 = new Form10();
            formulario10.Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario11 = new Form11();
            formulario11.Show();
        }
    }
}

