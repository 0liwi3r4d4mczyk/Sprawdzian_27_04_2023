using Sprawdzian.Classes;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> list = new();

        Student student1 = new("Adrian", "Nowak", 2006);
        Student student2 = new("Bartek", "Kowalczyk", 2001);
        Student student3 = new("Adam", "Kowal", 2008);


        list.Add(student1);
        list.Add(student2);
        list.Add(student3);
        Wydzial wydzial = new(list);

        wydzial.WypiszStudentow();


        wydzial.ZmienHasla();



        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nStudenci po zmianie hasla i sortowaniu: \n");
        Console.ForegroundColor = ConsoleColor.Gray;

        wydzial.ListaStudentow.Sort();
        wydzial.WypiszStudentow();
    }
}
