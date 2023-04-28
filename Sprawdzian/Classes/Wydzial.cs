using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian.Classes
{
    internal class Wydzial
    {
        List<Student> list;

        public List<Student> ListaStudentow
        {
            get { return list; }
            set { list = value; }
        }
        public Wydzial(List<Student> list)
        {
            this.list = list;
        }

        public void ZmienLoginy()
        {
            foreach (Student student in list)
            {
                Console.WriteLine($"Wpisz nowy login dla studenta: {student.Login}");
                string? login = Console.ReadLine();
                student.ZmienHaslo(login, student.Login);
            }
        }

        public void ZmienHasla()
        {
            foreach(Student student in list)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Wpisz nowe haslo dla studenta: {student.Login}");
                Console.ForegroundColor = ConsoleColor.Gray;

                string? haslo = Console.ReadLine();
                student.ZmienHaslo(haslo, student.Haslo);
            }
        }

        public void WypiszStudentow()
        {
            foreach(Student student in list)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
