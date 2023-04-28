using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian.Classes
{
    internal abstract class Uzytkownik
    {
        private Random rand = new();

        protected string imie, nazwisko, login = "", haslo = "";
        public string Imie
        {
            get { return imie; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
        }
        public string Login
        {
            get { return login; }
        }
        public string Haslo
        {
            get { return haslo; }
        }
        public Uzytkownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            login = $"{imie}_{nazwisko}";
            haslo = $"{imie.Substring(0, 3) + rand.Next(999999)}";
        }

        public string UkryjLogin()
        {
            return Szyfrowanie.ZaszyfrujCezar(login, 3);
        }
        public string UkryjHaslo()
        {
            return Szyfrowanie.ZaszyfrujCezar(haslo, 3);
        }
        public string PokazLogin()
        {
            return Szyfrowanie.OdszyfrujCezar(login, 3);
        }
        public string PokazHaslo()
        {
            return Szyfrowanie.OdszyfrujCezar(haslo, 3);
        }

        public abstract void ZmienLogin(string nowyLogin, string StaryLoginUzytkownika);
        public abstract void ZmienHaslo(string noweHaslo, string StareHasloUzytkownika);
    }
}
