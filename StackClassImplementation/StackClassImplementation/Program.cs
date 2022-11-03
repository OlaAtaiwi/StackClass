using System;

namespace StackClassImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Implementation Program");
            Console.WriteLine("Choose what you want\n1-integer Stack \n2-Employee Stack");
            int ch;
            string input = Console.ReadLine();
            if (int.TryParse(input, out ch))
            {
                CallingProperMethod(ch);
            }
            else
            {
                Console.WriteLine("Please enter numbers only");
            }
        }

        private static void CallingProperMethod(int ch)
        {
            switch (ch)
            {
                case 1:
                    IntegerStack();
                    break;
                case 2:
                    EmployeeStack();
                    break;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    break;
            }
        }

        private static void IntegerStack()
        {

            Console.WriteLine("Creating Integer Stack...");
            Stack<int> intStack = new Stack<int>();
            Console.WriteLine("Filling Stack with 20 integer values");
            FillIntStack(intStack);
            intStack.Print();
            Console.WriteLine("Peak item: " + intStack.Peak());
            Console.WriteLine($"Popped 2 items...({intStack.Pop()} & {intStack.Pop()})");
            Console.WriteLine("Our Stack now contains " + intStack.Count + " items");
            intStack.Print();
            Console.WriteLine("Clearing Stack...");
            intStack.Clear();
            Console.WriteLine("Our Stack now contains " + intStack.Count + " items");
            intStack.Print();
        }

        private static void EmployeeStack()
        {

            Console.WriteLine("Creating Employees Stack...");
            Stack<Employee> EmpStack = new Stack<Employee>();
            Console.WriteLine("Filling Stack with 20 Employees ");
            FillEmpStack(EmpStack);
            EmpStack.Print();
            Console.WriteLine("Peak item: " + EmpStack.Peak());
            Console.WriteLine($"Popped 2 items...({EmpStack.Pop()} & {EmpStack.Pop()})");
            Console.WriteLine("Our Stack now contains " + EmpStack.Count + " items");
            EmpStack.Print();
            Console.WriteLine("Clearing Stack...");
            EmpStack.Clear();
            Console.WriteLine("Our Stack now contains " + EmpStack.Count + " items");
            EmpStack.Print();
        }

        private static void FillEmpStack(Stack<Employee> empStack)
        {
            var fname = new string[] { "Liam ", "David ", "Henry","Michael", "Oliver ", "James ",
                "Jack ", "Daniel", "Mateo", "Robert" };
            var lname = new string[] { "Alberty ", "Alexander ", "Bell", "Brooks", "Hill", "Robinson", "Wattson", "Walker" };
            var Departments = new string[] { "HR", "Sales", "Financial", "Administrative" };
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
                empStack.Push(new Employee()
                {
                    FirstName = fname[rnd.Next(fname.Length)],
                    LastName = lname[rnd.Next(lname.Length)],
                    Department = Departments[rnd.Next(Departments.Length)]
                });
        }

        private static void FillIntStack(Stack<int> intStack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
                intStack.Push(rnd.Next(1, 101));
        }


    }
}
