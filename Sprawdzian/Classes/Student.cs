using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian.Classes
{
    internal class Student : Uzytkownik, IComparable
    {
        protected int rocznikStudiow;
        public Student(string imie, string nazwisko, int rocznikStudiow) : base(imie, nazwisko)
        {
            this.rocznikStudiow = rocznikStudiow;
        }

        public override string ToString()
        {
            return $"" +
                $"Imie: {imie}\n" +
                $"Nazwisko: {nazwisko}\n" +
                $"Rocznik Studiow: {rocznikStudiow}\n" +
                $"Login: {login}\n" +
                //Ukryj haslo szyfruje jeszcze raz wiec wyswietlony wynik bedzie po drugim szyfrowaniu
                $"Haslo: {UkryjHaslo()}\n";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Student) return false;

            if (((Student)obj).login == login && ((Student)obj).haslo == haslo) return true;
            else return false;
        }

        public override void ZmienHaslo(string noweHaslo, string StareHasloUzytkownika)
        {
            if (StareHasloUzytkownika != haslo) throw new Exception("Nieprawidlowe haslo");

            haslo = Szyfrowanie.ZaszyfrujCezar(noweHaslo, 3);
        }

        public override void ZmienLogin(string nowyLogin, string StaryLoginUzytkownika)
        {
            if (StaryLoginUzytkownika != login) throw new Exception("Nieprawidlowy login");

            login = Szyfrowanie.ZaszyfrujCezar(nowyLogin, 3);
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Student) return 0;

            if (((Student)obj).rocznikStudiow > rocznikStudiow)
                return 1;
            else
            {
                if (((Student)obj).imie[0] > imie[0] && ((Student)obj).nazwisko[0] > nazwisko[0])
                    return 1;
                else
                    return 0;
            }
        }
    }
}
