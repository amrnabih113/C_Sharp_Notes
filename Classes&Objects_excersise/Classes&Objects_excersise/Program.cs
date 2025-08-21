namespace ClassesAndObjects_excersise
{
    /* Exercise:
           Create a class Student with properties: Name, ID, Grades (list of int)
           Add methods: CalculateAverage(), AddGrade(int grade), PrintInfo()
           Create a few student objects, add grades, and print their averages
           Goal: Practice classes, objects, lists, methods, encapsulation.
        */
    class Program
    {
       
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Amr",new int[]{ 100, 92, 92, 25 });
            s1.AddGrade(99);
            Console.WriteLine("Student Information:");
            s1.PrintInfo();

            Student s2 = new Student(2, "Ahmed", new int[] { 85, 90, 78 });
            s2.AddGrade(88);
            Console.WriteLine("\nStudent Information:");
            s2.PrintInfo();

            Student s3 = new Student(3, "Sara", new int[] { 95, 88, 92 });
            s3.AddGrade(100);
            Console.WriteLine("\nStudent Information:");
            s3.PrintInfo();


        }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public Student(int id, string name, int[] grades)
        {
            Id = id;
            Name = name;
            Grades = grades;
        }

        public double CalculateAverage()
        { 
            double sum = 0d;
            for (int i = 0; i < Grades.Length; i++)
                sum += Grades[i];

            return sum / Grades.Length ;

        }

        public void AddGrade(int grade)
        {
            int[] newGrades = new int[Grades.Length + 1];
            for (int i = 0; i < Grades.Length; i++)
            {
                newGrades[i] = Grades[i];
            }
            newGrades[Grades.Length] = grade;
            Grades = newGrades;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine("Grades: ");
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.WriteLine(Grades[i]);
            }
            Console.WriteLine($"Average: {CalculateAverage()}");
        }
    }

}