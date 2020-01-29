using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje
{
    public partial class CtrlNastavnikRoditelj : UserControl
    {
        Panel panel;
        NijeUcenik korisnik;
        public CtrlNastavnikRoditelj()
        {
            InitializeComponent();
        }

        public CtrlNastavnikRoditelj(NijeUcenik korisnik, Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.korisnik = korisnik;
        }




        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            CtrlRoditelj ctrlRoditelj = new CtrlRoditelj(korisnik);
            panel.Controls.Clear();
            panel.Controls.Add(ctrlRoditelj);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            CtrlNastavnik ctrlNastavnika = new CtrlNastavnik(korisnik, panel);
            panel.Controls.Clear();
            panel.Controls.Add(ctrlNastavnika);
        }
    }
}
