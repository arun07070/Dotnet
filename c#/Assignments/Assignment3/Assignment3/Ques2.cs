using System;

namespace StudentProgram
{
    class StudentBase
    {
        protected int rollNo;
        protected string name;
        protected string studentClass;
        protected int sem;
        protected string branch;

        public StudentBase(int rollNo, string name, string studentClass, int sem, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.sem = sem;
            this.branch = branch;
        }

        public void DisplayData()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {sem}");
            Console.WriteLine($"Branch: {branch}");
        }
    }
    class Student : StudentBase
    {
        int[] marks = new int[5];

        public Student(int rollNo, string name, string studentClass, int sem, string branch)
            : base(rollNo, name, studentClass, sem, branch) { }

        public void GetMarks()
        {
            Console.WriteLine("\nEnter marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            foreach (int m in marks)
            {
                if (m < 35)
                    fail = true;

                total += m;
            }

            double avg = total / 5.0;

            Console.WriteLine($"Average: {avg}");

            if (fail)
                Console.WriteLine("Result: Failed (Subject < 35)");
            else if (avg < 50)
                Console.WriteLine("Result: Failed (Average < 50)");
            else
                Console.WriteLine("Result: Passed");
        }
    }
    class Program
    {
        static void Main()
        {
            Student stu = new Student(1, "Arun", "BSc", 3, "CS");
            stu.DisplayData();
            stu.GetMarks();
            stu.DisplayResult();
        }
    }
}