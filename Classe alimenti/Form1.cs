using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_alimenti
{
    public partial class Form1 : Form
    {
        public Articolo[] articoli;
        public int num;

        public Form1()
        {
            InitializeComponent();
            articoli = new Articolo[100];
            articoli[0] = new Articolo(); // head
            num = 1;
        }

        private void AggBut_Click(object sender, EventArgs e)
        {

        }
    }
}
