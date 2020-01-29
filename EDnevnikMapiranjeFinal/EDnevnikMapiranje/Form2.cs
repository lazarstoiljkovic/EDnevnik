using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje
{
    public partial class Form2 : Form
    {
        NijeUcenik korisnik;
        Panel panel;
        Form1 forma;
        public Form2(Form1 forma,NijeUcenik korisnik, Panel panel )
        {
            InitializeComponent();
            this.korisnik = korisnik;
            this.panel = panel;
            this.forma = forma;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            forma.LoginRoditelj(korisnik, panel);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            forma.LoginNastavnik(korisnik, panel);
        }
    }
}
