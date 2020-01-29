using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using EDnevnikMapiranje.DTOs;
using NHibernate.Linq;
using NHibernate;

namespace EDnevnikMapiranje
{
    public class DataProvider
    {
        public IEnumerable<OdeljenjeView> GetOdeljenjaView()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<Odeljenje> odeljenja = s.Query<Odeljenje>().Select(p => p);
  
            IEnumerable<OdeljenjeView> odeljenjeViews = Enumerable.Empty<OdeljenjeView>();
            IList<OdeljenjeView> lista = new List<OdeljenjeView>();
            foreach(Odeljenje o in odeljenja)
            {
                lista.Add(new OdeljenjeView(o));
            }
            odeljenjeViews = lista;
            return odeljenjeViews;
        }
        public OdeljenjeView GetOdeljenjeView(int id)
        {
            ISession s = DataLayer.getSession();
            Odeljenje odlj = s.Query<Odeljenje>().Where(o => o.IdOdeljenja == id).Select(p => p).FirstOrDefault();
            if (odlj == null) return new OdeljenjeView();

            return new OdeljenjeView(odlj);
        }
        public int AddOdeljenje(Odeljenje o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                s.Save(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemoveOdeljenje(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Odeljenje o = s.Get<Odeljenje>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdateOdeljenje(int id, Odeljenje o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Odeljenje ode = s.Load<Odeljenje>(id);
                ode.Naziv = o.Naziv;
                ode.Smer = o.Smer;
                ode.Raspored = o.Raspored;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

        public IEnumerable<FunkcijaView> GetFunkcijaViews()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<Funkcija> funkcije = s.Query<Funkcija>().Select(p => p);

            IEnumerable<FunkcijaView> funkcijeViews = Enumerable.Empty<FunkcijaView>();
            IList<FunkcijaView> lista = new List<FunkcijaView>();
            foreach (Funkcija o in funkcije)
            {
                lista.Add(new FunkcijaView(o));
            }
            funkcijeViews = lista;
            return funkcijeViews;
        }
        public FunkcijaView GetFunkcijaViewId(int id)
        {
            ISession s = DataLayer.getSession();
            Funkcija funkcija = s.Query<Funkcija>().Where(f => f.IdFunkcije == id).Select(p => p).FirstOrDefault();
            return new FunkcijaView(funkcija);
        }
        public int AddFunkcija(Funkcija f)
        {
            try
            {
                ISession s = DataLayer.getSession();
                s.Save(f);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemoveFunkcija(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Funkcija f = s.Get<Funkcija>(id);
                s.Delete(f);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdateFunkciju(int id, Funkcija f)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Funkcija fun = s.Load<Funkcija>(id);
                fun.TipFunkcije = f.TipFunkcije;
                s.Update(fun);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }


        public IEnumerable<NijeUcenikView> GetNijeUcenikViews()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<NijeUcenik> nijeUceniks = s.Query<NijeUcenik>().Select(p => p);
            IEnumerable<NijeUcenikView> retNijeUcenik = Enumerable.Empty<NijeUcenikView>();
            IList<NijeUcenikView> lista = new List<NijeUcenikView>();
            foreach (NijeUcenik nu in nijeUceniks)
            {
                lista.Add(new NijeUcenikView(nu));
            }
            retNijeUcenik = lista;
            return retNijeUcenik;
        }
        public NijeUcenikView GetNijeUcenikViewId(int id)
        {
            ISession s = DataLayer.getSession();
            NijeUcenik nu = s.Query<NijeUcenik>().Where(n => n.IdKorisnika == id).Select(p => p).FirstOrDefault();
            return new NijeUcenikView(nu);
        }
        public int AddNijeUcenik(NijeUcenik o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                s.Save(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemoveNijeUcenik(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                NijeUcenik o = s.Get<NijeUcenik>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdateNijeUcenik(int id, NijeUcenik o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                NijeUcenik ode = s.Load<NijeUcenik>(id);
                ode.Ime = o.Ime;
                ode.Prezime = o.Prezime;
                ode.AdministratorFlag = o.AdministratorFlag;
                ode.NastavnigFlag = o.NastavnigFlag;
                ode.RoditeljFlag = o.RoditeljFlag;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

        public IEnumerable<OcenaView> GetOcenaViews()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<Ocena> ocene = s.Query<Ocena>().Select(p => p);
            IEnumerable<OcenaView> retOcene = Enumerable.Empty<OcenaView>();
            IList<OcenaView> lista = new List<OcenaView>();
            foreach (Ocena nu in ocene)
            {
                lista.Add(new OcenaView(nu));
            }
            retOcene = lista;
            return retOcene;
        }
        public OcenaView GetOcenaViewId(int id)
        {
            ISession s = DataLayer.getSession();
            Ocena ocena = s.Query<Ocena>().Where(o => o.IdOcene == id).Select(p => p).FirstOrDefault();
            return new OcenaView(ocena);
        }
        public int AddOcena(Ocena o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                s.Save(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemoveOcena(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Ocena o = s.Get<Ocena>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdateOcena(int id, Ocena o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Ocena ode = s.Load<Ocena>(id);
                ode.Broj = o.Broj;
                ode.TipOcene = o.TipOcene;
                ode.Opis = o.Opis;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

        public IEnumerable<PredmetView> GetPredmetViews()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<Predmet> predmeti = s.Query<Predmet>().Select(p => p);
            IEnumerable<PredmetView> retPredmeti = Enumerable.Empty<PredmetView>();
            IList<PredmetView> lista = new List<PredmetView>();
            foreach (Predmet nu in predmeti)
            {
                lista.Add(new PredmetView(nu));
            }
            retPredmeti = lista;
            return retPredmeti;
        }
        public PredmetView GetPredmetViewId(int id)
        {
            ISession s = DataLayer.getSession();
            Predmet predmet = s.Query<Predmet>().Where(o => o.IdPredmeta == id).Select(p => p).FirstOrDefault();
            return new PredmetView(predmet);
        }
        public int AddPredmet(Predmet o)
        {
            try
            {
                Predmet pn;
                ISession s = DataLayer.getSession();
                if(o.TipPredmeta == "Obavezni")
                {
                    pn = new PredmetObavezni();
                }
                else
                {
                    pn = new PredmetIzborni();
                }
                pn.Naziv = o.Naziv;
                pn.Opis = o.Opis;
                pn.Razred = o.Razred;
               
                s.Save(pn);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemovePredmet(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Predmet o = s.Get<Predmet>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdatePredmetIzborni(int id, PredmetIzborni o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                PredmetIzborni ode = s.Load<PredmetIzborni>(id);
                ode.Naziv = o.Naziv;
                ode.TipPredmeta = o.TipPredmeta;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdatePredmetObavezni(int id, PredmetObavezni o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                PredmetObavezni ode = s.Load<PredmetObavezni>(id);
                ode.Naziv = o.Naziv;
                ode.TipPredmeta = o.TipPredmeta;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

        public IEnumerable<UcenikView> GetUcenikViews()
        {
            ISession s = DataLayer.getSession();
            IEnumerable<Ucenik> ucenici = s.Query<Ucenik>().Select(p => p);
            IEnumerable<UcenikView> retUcenik = Enumerable.Empty<UcenikView>();
            IList<UcenikView> lista = new List<UcenikView>();
            foreach (Ucenik nu in ucenici)
            {
                lista.Add(new UcenikView(nu));
            }
            retUcenik = lista;
            return retUcenik;
        }
        public UcenikView GetUcenikViewId(int id)
        {
            ISession s = DataLayer.getSession();
            Ucenik ucenik = s.Query<Ucenik>().Where(o => o.IdKorisnika == id).Select(p => p).FirstOrDefault();
            return new UcenikView(ucenik);
        }
        public int AddUcenik(Ucenik o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                o.OdeljenjeID = s.Load<Odeljenje>(82);
                o.RoditeljID = s.Load<NijeUcenik>(123);

                s.Save(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int RemoveUcenik(int id)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Ucenik o = s.Get<Ucenik>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }
        public int UpdateUcenik(int id, Ucenik o)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Ucenik ode = s.Load<Ucenik>(id);
                ode.Ime = o.Ime;
                ode.Prezime = o.Prezime;
                ode.OcenaVladanje = o.OcenaVladanje;
                s.Update(ode);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

    }
}
