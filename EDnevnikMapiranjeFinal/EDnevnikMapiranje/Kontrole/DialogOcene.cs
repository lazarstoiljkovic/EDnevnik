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
using NHibernate;

namespace EDnevnikMapiranje.Kontrole
{
    public partial class DialogOcene : Form
    {
        string nazivOdeljenja;
        Ucenik ucenik;
        
        public DialogOcene()
        {
            InitializeComponent();
        }

        public DialogOcene(string odeljenje,Ucenik ucenik)
        {
            InitializeComponent();
            this.nazivOdeljenja = odeljenje;
            this.ucenik = ucenik;
        }

        private void DialogOcene_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 15; i++)
            //{
            //    if (ucenik.ListaOcenaUcenikIma[i].GetType() == typeof(OpisnaOcena))
            //    {
            //        if (ucenik.ListaPredmateUcenikSlusa[i].Naziv.Equals(this.nazivOdeljenja))
            //        {
            //            lblOcene.Text = "Predmet: " + this.ucenik.ListaPredmateUcenikSlusa[i].Naziv + " " + this.ucenik.ListaOcenaUcenikIma[i].Opis;
            //        }
            //    }
            //    else
            //    {
            //        if (ucenik.ListaPredmateUcenikSlusa[i].Naziv.Equals(this.nazivOdeljenja))
            //        {
            //            lblOcene.Text = "Predmet: " + this.ucenik.ListaPredmateUcenikSlusa[i].Naziv + " " + this.ucenik.ListaOcenaUcenikIma[i].Broj;
            //        }

            //    }
                   
            //}  ne moze ovo ovako
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
