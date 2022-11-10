using System;
using System.Collections.Generic;

namespace OOP_Labb_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee FirstEmp = new Employee(1, "Billy", "M", 2500); //Creating employees
            Employee SilverEmp = new Employee(2, "Flash", "F", 1900);
            Employee Cerberus = new Employee(3, "Cerberus", "M", 1888);
            Employee NotLast = new Employee(4, "Sandra", "F", 1722);
            Employee PoorEmp = new Employee(5, "Pobrecito", "M", 100);

            Stack<Employee> Personal = new Stack<Employee>();//Creating stack and Pushing employees to the stack Personal
            Personal.Push(FirstEmp);
            Personal.Push(SilverEmp);
            Personal.Push(Cerberus);
            Personal.Push(NotLast);
            Personal.Push(PoorEmp);

            Console.WriteLine("WRITING EMPLOYEES:");//Writing all values of PersonalStack and counting
            foreach (Employee item in Personal) 
            {
                Console.WriteLine("\n- ID:{0}, Name:{1}, Gender:{2},  Salary:{3}", item.id, item.name, item.gender, item.salary);
                Console.WriteLine("Employees:{0}" , Personal.Count);
            }
            Console.WriteLine();

            Console.WriteLine("POPPING :");             //Popping all employees and counting
            Personal.Pop();
            Console.WriteLine("Employees left after POP: {0}", Personal.Count);
            Personal.Pop();
            Console.WriteLine("Employees left after POP: {0}", Personal.Count);
            Personal.Pop();
            Console.WriteLine("Employees left after POP: {0}", Personal.Count);
            Personal.Pop();
            Console.WriteLine("Employees left after POP: {0}", Personal.Count);
            Personal.Pop();
            Console.WriteLine("Employees left after POP: {0}", Personal.Count);

            Console.WriteLine("Pushing them back!");   //Pushing all employees again
            Personal.Push(FirstEmp);
            Personal.Push(SilverEmp);
            Personal.Push(Cerberus);
            Personal.Push(NotLast);
            Personal.Push(PoorEmp);

            Console.WriteLine("Peeking:");//Using Peek to peek, two times. Same result Though
            Employee peek = Personal.Peek();
            Console.WriteLine("\nID: {0}, Name: {1} ", peek.id, peek.name);
            Console.WriteLine("Employees after peeking: {0}", Personal.Count);

            Employee peek2 = Personal.Peek();
            Console.WriteLine("\nID: {0}, Name: {1} ", peek2.id, peek2.name);
            Console.WriteLine("Employees after peeking: {0}", Personal.Count);

            Console.WriteLine("\nChecking:");
            if (Personal.Contains(Cerberus)) //Kollar om stacken Personal innehåller Cerberus
            { 
                Console.WriteLine(Cerberus.name+" exists in stack");
            }
            else 
            { 
                Console.WriteLine("Person could not be found"); 
            }

            Console.WriteLine("---------------------------------------------------------------------");
            //Part One finished

            List<Employee> AnLista = new List<Employee>();  //Creates a list of the the employees
            AnLista.Add(FirstEmp);
            AnLista.Add(SilverEmp);
            AnLista.Add(Cerberus);
            AnLista.Add(NotLast);
            AnLista.Add(PoorEmp);

            if (AnLista.Contains(NotLast))//Kollar om fjärde anställda existerar och skriver ut resultatet
            {
                Console.WriteLine(NotLast.name+" object exists in the list");
            }
            else { Console.WriteLine(NotLast.name+" object does not exist in the list"); }

            Console.WriteLine();
            Employee man = AnLista.Find(e => e.gender == "M"); //Letar efter första objektet som är M/Male
            Console.WriteLine("Found the Male: -"+man.name+"\n"); //Skriver ut det
            Console.WriteLine("Found All males:");          //Letar efter alla Males och skriver ut dem
            List<Employee> men = AnLista.FindAll(e => e.gender == "M");
            foreach(Employee item in men)
            {
                Console.WriteLine("-"+ item.gender + " : " + item.name);
            }
        }
    }
}
