using System;

namespace Week2Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();
            var student4 = new Student();
            var student5 = new Student();
            var student6 = new Student();
            var student7 = new Student();
            var student8 = new Student();
            var student9 = new Student();
            var student10 = new Student();
            var student11 = new Student();
            var student12 = new Student();

            student1.Name = "Pablo Gamez";
            student1.Major = "Computer Science";
            student1.AddSubjects("Math", "English", "Geology");
            student1.PrintStudentInfo();

            student2.Name = "John Gomez";
            student2.Major = "History";
            student2.AddSubjects("Math", "History", "English");
            student2.PrintStudentInfo();

            student3.Name = "Cabe Smith";
            student3.Major = "History";
            student3.AddSubjects("English", "History");
            student3.PrintStudentInfo();

            student4.Name = "Susan Roberts";
            student4.Major = "Computer Science";
            student4.AddSubjects("Math","Geology");
            student4.PrintStudentInfo();

            student5.Name = "Johny Michaels";
            student5.Major = "History";
            student5.AddSubjects("History", "Geology");
            student5.PrintStudentInfo();

            student6.Name = "Carol Jones";
            student6.Major = "History";
            student6.AddSubjects("English", "Math");
            student6.PrintStudentInfo();

            student7.Name = "Peter Garcia";
            student7.Major = "Computer Science";
            student7.AddSubjects("Math");
            student7.PrintStudentInfo();

            student8.Name = "John Gomez";
            student8.Major = "History";
            student8.AddSubjects("History");
            student8.PrintStudentInfo();

            student9.Name = "Mike Lee";
            student9.Major = "History";
            student9.AddSubjects("English", "History");
            student9.PrintStudentInfo();

            student10.Name = "Pablo Gamez";
            student10.Major = "Computer Science";
            student10.AddSubjects("Math", "English", "Geology");
            student10.PrintStudentInfo();

            student11.Name = "John Gomez";
            student11.Major = "History";
            student11.AddSubjects("Geology", "Natural Science");
            student11.PrintStudentInfo();

            student12.Name = "Kabe White";
            student12.Major = "History";
            student12.AddSubjects("English", "History", "Biology");
            student12.PrintStudentInfo();


        }
    }
}
