using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplitoGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sumar(int a, int b)
        {
            return a + b;
        }

	private void Salir(){
		Application.Exit();
	}

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            MessageBox.Show("Hola");
        }
	
	
        private void button2_Click(object sender, EventArgs e)
        {
	    Console.Write("Hola mundo");
	    Console.Write("Ornitorrinco");
	    
            // Nada por aca...
		
	    Console.Write("Otra rama");
        }

    }
}
