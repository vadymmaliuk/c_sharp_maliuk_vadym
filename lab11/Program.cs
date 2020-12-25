using System;
using System.Collections.Generic;

namespace lab_11_Maliuk_Vadym
{
    class Program
    {
        static void Main(string[] args)
        {
            //�������� #1
            Product prod = new Product();

            Fabric fabric = new Fabric();


            fabric.SharpAndDrill(prod);
            fabric.DisplayInfo(prod);
            Console.WriteLine();
            fabric.CompleteProduct(prod);
            fabric.DisplayInfo(prod);

            //�������� #2
            List<Student> pd22Group = new List<Student>();

            pd22Group.Add(new Student("Bodya", "Danulyk", 16));
            pd22Group.Add(new Student("Daniel", "Bilodid", 21));
            pd22Group.Add(new Student("Dana", "Prokopets", 19));
            pd22Group.Add(new Student("Dima", "Vdovin", 23));
            pd22Group.Add(new Student("Vlad", "Osymak", 17));
            pd22Group.Add(new Student("Valera", "Bilous", 18));
            pd22Group.Add(new Student("Artem", "Iluchenko", 24));
            pd22Group.Add(new Student("Vitalik", "Woloshyn", 15));
            pd22Group.Add(new Student("Edik", "Petrenko", 13));
            pd22Group.Add(new Student("Bohdan", "Student", 44));


            List<Student> adults = new List<Student>();
            StudentPredicateDelegate spd;

            //task 8
            Console.WriteLine("\nONLY ADULT PEOPLE HERE");
            spd = Student.Adult;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nSTUDENTS WHO HAVE 'A' AS THE FIRST LETTER IN FIRS NAME");
            spd = Student.FirstSymbolIsA;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nSTUDENTS WHO HAVE LAST NAME LONGER THAN 3 SYMBOLS ");
            spd = Student.LongLastName;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //using anonymous methods - �������� 9
            Console.WriteLine("\n\nHERE I USE ANONIMOUS METHODS");
            Console.WriteLine("\nADULTS");
            spd = student => student.Age >= 18 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nFIRST LETTER IS 'A'");
            spd = student => student.FirstName[0] == 'A' ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nLAST NAME > 3");
            spd = student => student.LastName.Length > 3 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();


            //�������� 10 - finding students among 20 and 25 y.o.
            Console.WriteLine("\n\nGRANDFATHERS 20 - 25 YEARS OLD");
            spd = student => student.Age > 20 && student.Age < 25 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //�������� 11
            Console.WriteLine("\nWE'RE FINDING ANDREW HERE");
            spd = student => student.FirstName == "Andrew" ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //�������� 12
            Console.WriteLine("\nWHERE IS THE TROELSEN???");
            spd = student => student.LastName == "Troelsen" ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

        }
    }
}