using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Security.Cryptography;

namespace Zadaca2
{
    public enum Spol { Musko, Zensko };
    public enum BracnoStanje { Zarucen_a, Ozenjen_Udata, Neozenjen_Neudata, Razveden_a, Udovac_ica };
    public enum Uloga { Administrator, Uprava, Doktor, Medicinsko_osoblje, Pacijent, Ostali_Korisnici };

    
    [Serializable]
    public class Osoba
    {
        protected string ime;
        protected string prezime;
        protected DateTime datumRodjenja;
        protected string maticniBroj;
        protected string adresa;
        protected Spol spol;
        protected BracnoStanje bracnoStanje;
        string email;

        private string korisnickoIme;
        private string lozinka;
        private Uloga uloga;

        public Osoba() { }
        public Osoba(string ime, string prezime, DateTime datumRodjenja, string maticniBroj, string adresa, Spol spol, BracnoStanje bracnoStanje, string email, Uloga uloga)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            MaticniBroj = maticniBroj;
            Adresa = adresa;
            Spol = spol;
            BracnoStanje = bracnoStanje;
            korisnickoIme = KreirajKorisnickoIme();
            lozinka = KreirajLozinku();
            Email = email;
            Uloga = uloga;
        }

        public string Ime
        {
            get => ime;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                ime = value;
            }
        }
        public string Prezime
        {
            get => prezime;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                prezime = value;
            }
        }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string MaticniBroj
        {
            get => maticniBroj; set
            {
                try
                {
                    ValidirajMaticniBroj(value);
                    maticniBroj = value;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
        public string Adresa
        {
            get => adresa;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new Exception("Polje ne smije biti prazno");
                adresa = value;
            }
        }
        public Spol Spol { get => spol; set => spol = value; }
        public BracnoStanje BracnoStanje { get => bracnoStanje; set => bracnoStanje = value; }
        public string KorisnickoIme
        {
            get => korisnickoIme;
            
        }
        public string Lozinka
        {
            get => lozinka;
            set
            {
                if (value.Length < 7) throw new Exception("Lozinka mora imati minimalno 7 znakova");
                lozinka = Kodiraj(value);
            }
        }

        public Uloga Uloga { get => uloga; set => uloga = value; }
        public string Email
        {
            get => email;
            set
            {
                bool imaAt=false, imaTacku=false;
                for(int i=0; i<value.Length; i++)
                {
                    if (value[i] == '@') imaAt = true;
                    if (value[i] == '.') imaTacku = true;
                }
                if (!imaTacku || !imaAt) throw new Exception("Neispravan format e-mail adrese");
                email = value;
            }
        }

        public void ValidirajMaticniBroj(string jmbg)
        {
            if (jmbg.Length != 13 || String.IsNullOrWhiteSpace(jmbg) || String.IsNullOrEmpty(jmbg))
                throw new Exception ("Maticni broj mora imati 13 cifara");
            for(int i=0; i<jmbg.Length; i++)
            {
                if (jmbg[i]<'0' || jmbg[i]>'9') throw new Exception("Maticni broj mora sadrzavati samo cifre");
            }
            
        }
        public bool ValidirajKorisnickoIme(string kime)
        {
            for (int i = 0; i < Glavna.Klinika17280_1.RegistrovaneOsobe.Count; i++)
            {
                if (Glavna.Klinika17280_1.RegistrovaneOsobe[i].KorisnickoIme == kime) return false; 
            }
            return true;
        }
        public string KreirajKorisnickoIme()
        {
            string kime = "";
            int br = 1;
            kime += Ime[0].ToString().ToLower() + Prezime.ToLower();
            string pom = kime; pom += br;
            while(!ValidirajKorisnickoIme(pom))
            {
                pom = kime;
                br++;
                pom += br;
            }
            kime = pom;

            return kime;
        }
        public static string Kodiraj(string tekst)
        {
            using (MD5CryptoServiceProvider md5 =new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(tekst));
                return Convert.ToBase64String(data);
            }
        }
        public string KreirajLozinku()
        {
            string lozinka;
            lozinka = Kodiraj( Membership.GeneratePassword(7, 1) );
            return lozinka;
        }
        public override string ToString()
        {
            string rez = "";
            rez += "\nIme i prezime: " + Ime + " " + Prezime +
                 "\nDatum rodjenja: " + DatumRodjenja.ToShortDateString() +
                 "\nMaticni broj: " + MaticniBroj +
                 "\nAdresa: " + Adresa +
                 "\nSpol: " + Spol +
                 "\nBracno stanje: " +  BracnoStanje;
            return rez;
        }
    }
}
