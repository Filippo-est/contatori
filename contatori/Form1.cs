using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace contatori
{
    public partial class Form1 : Form
    {
        Contatore c = new Contatore();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
           
            c.incrementa();
            label1.Text = c.visualizza();
                
            
        }
    }
    class Contatore
    {
        int cont;

        public Contatore()
        { cont = 0; }

        public void incrementa()
        {
            cont++;
        }

        public string visualizza()
        {
            return cont.ToString();
        }

    }
}
