using EDnevnikMapiranje.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDnevnikMapiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 Message;

        //Izmenjena baza
        //alter table UCENIK add RODITELJ_ID NUMBER(10) not null;
        //alter table UCENIK add constraint fk_roditelj foreign key (RODITELJ_ID) references NIJE_UCENIK (ID_KORISNIK);

        //update UCENIK set RODITELJ_ID = 6 where ID_KORISNIK = 4;

        //alter table UCENIK modify  RODITELJ_ID not null;

        //alter table PREDAJE drop column ID;

        //alter table PREDAJE add constraint pk_predaje primary key (NASTAVNIK_ID,PREDMET_ID) enable;
        //alter table ucenik add(RODITELJ_ID number(10));
        //alter table ucenik modify RODITELJ_ID not null;
        //alter table ucenik add constraint fk_ucenik foreign key(RODITELJ_ID) references NIJE_UCENIK(ID_KORISNIK);
        //alter table je_razredni drop column id;
        //alter table je_razredni add constraint razredni_pk primary key(razredni_staresina_id, odeljenje_id);
        //alter table predmet add constraint jedinstven_uq unique (naziv,razred);
        //--alter table ocena add constraint broj_ck check(broj in (0,1,2,3,4,5));
        //--alter table predmet add constraint jedinstven_uq unique (naziv,razred);
        //--create sequence sekvenca_ocena
        //--start with 1
        //--increment by 1;
        //--
        //--create or replace trigger ocena_id_auto
        //--before insert 
        //--on Ocena
        //--referencing new as new
        //--for each row
        //--begin
        //--select sekvenca_ocena.nextval into :new.id_ocena from dual;
        //--end;

        //Mozda ne mora
        //alter table je_razredni drop constraint je_razredni_pk;
        //delete from je_razredni where id like 24;
        //alter table je_razredni add constraint je_razredni_pk primary key(razredni_staresina_id, odeljenje_id);
        //delete from obavlja_funkciju where id like 1;
        //alter table obavlja_funkciju drop constraint obavljafunkciju_pk;
        //alter table obavlja_funkciju add constraint obavljafunkciju_pk primary key(roditelj_id, funkcija_id);
        //alter table predaje drop constraint predaje_pk;
        //alter table predaje add constraint predaje_pk primary key(nastavnik_id, predmet_id);
        private void btnUcitajKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Korisnik> korisnici = s.QueryOver<Korisnik>()
                                       .List<Korisnik>();

                foreach (Korisnik k in korisnici)
                {
                    MessageBox.Show(k.Ime);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                Odeljenje o = s.Load<Odeljenje>(1);

                foreach (Ucenik u in o.ListaUcenika)
                {
                    MessageBox.Show(o.Naziv + " Ucenik : " + u.Ime);
                }


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajOcenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Ocena> ocene = s.QueryOver<Ocena>()
                                        .List<Ocena>();

                //Ocena o = s.Load<Ocena>(1);
                foreach (Ocena o in ocene)
                {
                    if (o.GetType() == typeof(BrojcanaOcena))
                    {
                        MessageBox.Show("Brojcana ocena, broj :" + o.Broj);
                    }
                    else if (o.GetType() == typeof(OpisnaOcena))
                    {
                        MessageBox.Show("Opisna ocena, opis :" + o.Opis);
                    }
                    else
                    {
                        MessageBox.Show("Nista");
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Predmet> predmeti = s.QueryOver<Predmet>()
                                        .List<Predmet>();

                foreach (Predmet p in predmeti)
                {
                    if (p.GetType() == typeof(PredmetIzborni))
                    {
                        MessageBox.Show("Izborni predmet : " + p.Naziv);
                    }
                    else if (p.GetType() == typeof(PredmetObavezni))
                    {
                        MessageBox.Show("Obavezni predmet : " + p.Naziv);
                    }
                    else
                    {
                        MessageBox.Show("Nista");
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajFunkciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                Funkcija f = s.Load<Funkcija>(1);

                MessageBox.Show(f.TipFunkcije);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajUcenika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Korisnik> korisnici = s.QueryOver<Korisnik>()
                                       .List<Korisnik>();

                foreach (Korisnik k in korisnici)
                {
                    if (k.GetType() == typeof(Ucenik))
                    {

                        MessageBox.Show(((Ucenik)k).Ime);
                    }
                }
                //Ucenik u = (Ucenik)korisnici[3];

                //MessageBox.Show(u.RoditeljID.IdKorisnika.ToString());

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajNijeUcenik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Korisnik> korisnici = s.QueryOver<Korisnik>()
                                       .List<Korisnik>();

                //Svaki put ide ovo !!!
                foreach (Korisnik k in korisnici)
                {
                    if (k.GetType() == typeof(NijeUcenik))
                    {
                        if (((NijeUcenik)k).RoditeljFlag == "Da")
                            MessageBox.Show(k.Ime);
                    }
                }
                //NijeUcenik nu = (NijeUcenik)korisnici[3];



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCitaIzPredaje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                NijeUcenik nastavnik = s.Load<NijeUcenik>(2);

                foreach (Predmet p in nastavnik.ListaPredmeta)
                {
                    MessageBox.Show(p.Naziv);
                }



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOdjaviSe.Visible = false;

            CtrlLogin ctrlLogin = new CtrlLogin(this);
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrlLogin);
        }

        private void btnCitajJeRazredni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                NijeUcenik razredni = s.Load<NijeUcenik>(8);
                foreach (Odeljenje o in razredni.Odeljenja)
                {
                    MessageBox.Show(o.Naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObavljaFunkciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                NijeUcenik roditelj = s.Load<NijeUcenik>(6);
                foreach (Funkcija f in roditelj.Funkcije)
                {
                    MessageBox.Show(f.TipFunkcije);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnCitajImaOcenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Ucenik ucenik = s.Load<Ucenik>(1);
                foreach (Ocena o in ucenik.ListaOcenaUcenikIma)
                {
                    MessageBox.Show(o.Broj.ToString());
                }
                Ocena ocena = s.Load<Ocena>(1);
                foreach (Ucenik u in ocena.ListaUcenikaOcena)
                {
                    MessageBox.Show(u.Ime);
                }
                foreach (Predmet p in ocena.ListaPredmetaOcena)
                {
                    MessageBox.Show(p.Naziv);
                }
                Predmet predmet = s.Load<Predmet>(1);
                foreach (Ucenik u in predmet.ListaUcenikaPredmet)
                {
                    MessageBox.Show(u.Ime);
                }
                foreach (Ocena o in predmet.ListaOcenaPredmet)
                {
                    MessageBox.Show(o.Broj.ToString());
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCitajDrziPredmetOdeljenju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                //Odeljenje odeljenje = s.Load<Odeljenje>(1);
                //MessageBox.Show(odeljenje.NastavnikZaPredmet[0].Ime);
                //Predmet predmet = s.Load<Predmet>(2);
                //foreach (Odeljenje o in predmet.ListaOdeljenjaPredmet)
                //{
                //    MessageBox.Show(o.Naziv);
                //}
                NijeUcenik nastavnik = s.Load<NijeUcenik>(6);
                foreach (Odeljenje o in nastavnik.ListaOdeljenjaNastavnik)
                {
                    MessageBox.Show(o.Naziv);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajFunkciju_Click(object sender, EventArgs e)
        {
            CtrlDodajFunkciju ctrlDodajFunkciju = new CtrlDodajFunkciju();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrlDodajFunkciju);
        }

        private void btnDodajOdeljenje_Click(object sender, EventArgs e)
        {
            CtrlDodajOdeljenje ctrlDodajOdeljenje = new CtrlDodajOdeljenje();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajOdeljenje);
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            CtrlDodajPredmet ctrlDodajPredmet = new CtrlDodajPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajPredmet);
        }

        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {
            CtrlDodajOcenu ctrlDodajOcenu = new CtrlDodajOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajOcenu);
        }

        private void BtnDodajKorisnika_Click(object sender, EventArgs e)
        {
            CtrlDodajKorisnika ctrlDodajKorisnika = new CtrlDodajKorisnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajKorisnika);
        }

        private void BtnDodajUcenika_Click(object sender, EventArgs e)
        {
            CtrlDodajUcenika ctrlDodajUcenika = new CtrlDodajUcenika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajUcenika);
        }

        private void BtnDodajAdmin_Click(object sender, EventArgs e)
        {
            CtrlDodajAdministratora ctrlDodajAdministratora = new CtrlDodajAdministratora();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajAdministratora);
        }

        private void BtnDodajNastavnika_Click(object sender, EventArgs e)
        {
            CtrlDodajNastavnika ctrlDodajNastavnika = new CtrlDodajNastavnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajNastavnika);
        }

        private void BtnDodajRoditelja_Click(object sender, EventArgs e)
        {
            CtrlDodajRoditelja ctrlDodajRoditelja = new CtrlDodajRoditelja();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajRoditelja);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtrlDodajNastavnikPredmet ctrlDodajNastavnikPredmet = new CtrlDodajNastavnikPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajNastavnikPredmet);
        }

        private void btnObavljaFun_Click(object sender, EventArgs e)
        {
            CtrlObavljaFunkciju ctrlObavljaFunkciju = new CtrlObavljaFunkciju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlObavljaFunkciju);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CtrlDodajJeRazredni ctrlDodajJeRazredni = new CtrlDodajJeRazredni();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajJeRazredni);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CtrlDodajIImaOcenu ctrlDodajIImaOcenu = new CtrlDodajIImaOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDodajIImaOcenu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CtrlDrziPredmetOdeljenju ctrlDrziPredmetOdeljenju = new CtrlDrziPredmetOdeljenju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlDrziPredmetOdeljenju);
        }

        private void BtnAzurirajFunkciju_Click(object sender, EventArgs e)
        {
            CtrlAzurirajFunckiju ctrlAzurirajFunckiju = new CtrlAzurirajFunckiju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajFunckiju);
        }

        private void BtnAzurirajOdeljenje_Click(object sender, EventArgs e)
        {
            CtrlAzurirajOdeljenje ctrlAzurirajOdeljenje = new CtrlAzurirajOdeljenje();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajOdeljenje);
        }

        private void btnAzurirajPredmet_Click(object sender, EventArgs e)
        {
            CtrlAzurirajPredmet ctrlAzurirajPredmet = new CtrlAzurirajPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajPredmet);
        }


        private void BtnBrisiFunkciju_Click(object sender, EventArgs e)
        {
            CtrlBrisiFunkciju ctrlBrisiFunkciju = new CtrlBrisiFunkciju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiFunkciju);
        }

        private void btnAzurirajOcenu_Click(object sender, EventArgs e)
        {
            CtrlAzurirajOcenu ctrlAzurirajOcenu = new CtrlAzurirajOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajOcenu);
        }

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            CtrlAzurirajKorisnika ctrlAzurirajKorisnika = new CtrlAzurirajKorisnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void btnAzurirajUcenika_Click(object sender, EventArgs e)
        {
            CtrlAzurirajUcenika ctrlAzurirajUcenika = new CtrlAzurirajUcenika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajUcenika);
        }

        private void btnDodajAdministratora_Click(object sender, EventArgs e)
        {
            CtrlAzurirajAdministratora ctrlAzurirajAdministratora = new CtrlAzurirajAdministratora();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajAdministratora);
        }

        private void btnAzurirajRoditelja_Click(object sender, EventArgs e)
        {
            CtrlAzurirajRoditelja ctrlAzurirajRoditelja = new CtrlAzurirajRoditelja();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajRoditelja);
        }

        private void btnAzurirajNastavnika_Click(object sender, EventArgs e)
        {
            CtrlAzurirajNastavnika ctrlAzurirajNastavnika = new CtrlAzurirajNastavnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajNastavnika);
        }

        private void btnBrisiOdeljenje_Click(object sender, EventArgs e)
        {
            CtrlBrisiOdeljenje ctrlBrisiOdeljenje = new CtrlBrisiOdeljenje();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiOdeljenje);
        }

        private void btnBrisiPredmet_Click(object sender, EventArgs e)
        {
            CtrlBrisiPredmet ctrlBrisiPredmet = new CtrlBrisiPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiPredmet);
        }

        private void btnBrisiOcenu_Click(object sender, EventArgs e)
        {
            CtrlBrisiOcenu ctrlBrisiOcenu = new CtrlBrisiOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiOcenu);
        }

        private void btnBrisiKorisnik_Click(object sender, EventArgs e)
        {
            CtrlBrisiKorisnik ctrlBrisiKorisnik = new CtrlBrisiKorisnik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiKorisnik);
        }

        private void btnBrisiUcenik_Click(object sender, EventArgs e)
        {
            CtrlBrisiUcenik ctrlBrisiUcenik = new CtrlBrisiUcenik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiUcenik);
        }

        private void btnBrisiOdeljenje_Click_1(object sender, EventArgs e)
        {
            CtrlBrisiOdeljenje ctrlBrisiOdeljenje = new CtrlBrisiOdeljenje();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiOdeljenje);
        }

        private void btnBrisiPredmet_Click_1(object sender, EventArgs e)
        {
            CtrlBrisiPredmet ctrlBrisiPredmet = new CtrlBrisiPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiPredmet);
        }

        private void btnBrisiOcenu_Click_1(object sender, EventArgs e)
        {
            CtrlBrisiOcenu ctrlBrisiOcenu = new CtrlBrisiOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiOcenu);
        }

        private void btnBrisiKorisnik_Click_1(object sender, EventArgs e)
        {
            CtrlBrisiKorisnik ctrlBrisiKorisnik = new CtrlBrisiKorisnik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiKorisnik);
        }

        private void btnBrisiUcenik_Click_1(object sender, EventArgs e)
        {
            CtrlBrisiUcenik ctrlBrisiUcenik = new CtrlBrisiUcenik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiUcenik);
        }

        private void btnBrisiNijeUcenik_Click(object sender, EventArgs e)
        {
            CtrlBrisiNijeUcenik ctrlBrisiNijeUcenik = new CtrlBrisiNijeUcenik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiNijeUcenik);
        }

        private void btnBrisiNastavnikPredmet_Click(object sender, EventArgs e)
        {
            CtrlBrisiNastavnikPredmet brisiNastavnikPredmet = new CtrlBrisiNastavnikPredmet();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(brisiNastavnikPredmet);
        }

        private void btnBrisiObavljaFunkciju_Click(object sender, EventArgs e)
        {
            CtrlBrisiObavljaFunkciju ctrlBrisiObavljaFunkciju = new CtrlBrisiObavljaFunkciju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiObavljaFunkciju);
        }

        private void btnBrisiJeRazredni_Click(object sender, EventArgs e)
        {
            CtrlBrisiJeRazredni ctrlBrisiJeRazredni = new CtrlBrisiJeRazredni();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiJeRazredni);
        }

        private void btnBrisiImaOcenu_Click(object sender, EventArgs e)
        {
            CtrlBrisiImaOcenu ctrlBrisiImaOcenu = new CtrlBrisiImaOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiImaOcenu);
        }

        private void btnBrisiDrziPredmetOdeljenju_Click(object sender, EventArgs e)
        {
            CtrlBrisiDrziPredmetOdeljenju ctrlBrisiDrziPredmetOdeljenju = new CtrlBrisiDrziPredmetOdeljenju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiDrziPredmetOdeljenju);
        }

        public void LogInSuccess(Korisnik korisnik)
        {
            btnOdjaviSe.Visible = true;
            if (korisnik.GetType() == typeof(Ucenik))
            {
                CtrlUcenik ctrlUcenik = new CtrlUcenik((Ucenik)korisnik);
                panelForme.Controls.Clear();
                panelForme.Controls.Add(ctrlUcenik);
            }
            else if (korisnik.GetType() == typeof(NijeUcenik))
            {

                if (((NijeUcenik)korisnik).AdministratorFlag == "Da")
                {
                    CtrlAdministrator ctrlAdministrator = new CtrlAdministrator();
                    panelForme.Controls.Clear();
                    panelForme.Controls.Add(ctrlAdministrator);
                }
                else if (((NijeUcenik)korisnik).NastavnigFlag == "Da" && ((NijeUcenik)korisnik).RoditeljFlag == "Da")
                {
                    Form2 form2 = new Form2(this,(NijeUcenik)korisnik,panelForme);

                    form2.Show();

                    Message = form2;

                   // CtrlNastavnikRoditelj ctrlNastavnikRoditelj = new CtrlNastavnikRoditelj((NijeUcenik)korisnik, panelForme);
                   // panelForme.Controls.Clear();
                   // panelForme.Controls.Add(ctrlNastavnikRoditelj);
                }
                else if (((NijeUcenik)korisnik).NastavnigFlag == "Da")
                {
                    CtrlNastavnik ctrlNastavnik = new CtrlNastavnik((NijeUcenik)korisnik, panelForme);
                    panelForme.Controls.Clear();
                    panelForme.Controls.Add(ctrlNastavnik);
                }
                else if (((NijeUcenik)korisnik).RoditeljFlag == "Da")
                {
                    CtrlRoditelj ctrlRoditelj = new CtrlRoditelj((NijeUcenik)korisnik);
                    panelForme.Controls.Clear();
                    panelForme.Controls.Add(ctrlRoditelj);
                }
            }
            else
            {
                MessageBox.Show("Nerasporedjen");
            }
        }

        private void BtnOdjaviSe_Click(object sender, EventArgs e)
        {
            CtrlLogin ctrlLogin = new CtrlLogin(this);
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrlLogin);
            btnOdjaviSe.Visible = false;
        }

        private void panelForme_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoginRoditelj(Korisnik korisnik, Panel panel)
        {
            CtrlRoditelj ctrlRoditelj = new CtrlRoditelj((NijeUcenik)korisnik);
            panel.Controls.Clear();
            panel.Controls.Add(ctrlRoditelj);
            Message.Hide();

        }

        public void LoginNastavnik(Korisnik korisnik, Panel panel)
        {
            CtrlNastavnik ctrlNastavnika = new CtrlNastavnik((NijeUcenik)korisnik, panel);
            panel.Controls.Clear();
            panel.Controls.Add(ctrlNastavnika);
            Message.Hide();
        }

    }
}
