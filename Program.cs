
using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace Labb8_OOP_Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Part One - Stack ~~~\n");

            // Instantiating new objects from the Class Employee
            Employee emp1 = new Employee()
            { _Id = 101, _name = "John", _gender = "male", _salary = 15000 };

            Employee emp2 = new Employee()
            { _Id = 102, _name = "Sara", _gender = "female", _salary = 18000 };

            Employee emp3 = new Employee()
            { _Id = 103, _name = "Anders", _gender = "male", _salary = 20000 };

            Employee emp4 = new Employee()
            { _Id = 104, _name = "Sally", _gender = "female", _salary = 22000 };

            Employee emp5 = new Employee()
            { _Id = 105, _name = "Daniel", _gender = "male", _salary = 25000 };                    

            Stack<Employee> employees = new Stack<Employee>(); // Creation of a Stack
            
            // Adding new objects to the Stack
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            Console.WriteLine($"Stack has {employees.Count()} employees."); // Displays available count of employees 

            foreach (Employee employee in employees) // A Loop that displays all members in the Stack Employee
            {
                Console.WriteLine($"ID: {employee._Id}, Name: {employee._name}, Gender: {employee._gender}, Salary: {employee._salary}");
                Console.WriteLine($"Stack has {employees.Count()} employees.");
            }
            Console.WriteLine("--------------------------------------------------");
           
            while (employees.Count != 0) // A Loop that runs until last item in the Stack is popped  
            {
                Employee poppedItem = employees.Pop();
                Console.WriteLine($"ID: {poppedItem._Id}, Name: {poppedItem._name}, Gender: {poppedItem._gender}, Salary: {poppedItem._salary} is removed from the stack.");
                Console.WriteLine($"Stack is left with {employees.Count()} items.");
                Console.WriteLine("");               
            }
            Console.WriteLine("The stack is empty! ");
            Console.WriteLine("--------------------------------------------------");

            // Adding again objects to the Stack
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee._Id}, Name: {employee._name}, Gender: {employee._gender}, Salary: {employee._salary}");
            }


            Employee peekedEmp = employees.Peek();
            Console.WriteLine($"ID: {peekedEmp._Id}, Name: {peekedEmp._name}");
            Console.WriteLine($"Stack has {employees.Count()} items.");
            Console.WriteLine("");

            Console.WriteLine("~~~ Part Two - List ~~~\n");

            // A list containing the instantiated objects
            List<Employee> employeeList = new List<Employee> { emp1, emp2, emp3, emp4, emp5 };

            if (employeeList.Contains(emp3))
            {
                Console.WriteLine($"Employee with ID {emp3._Id} exists in the list.\n");
            }
            else
            {
                Console.WriteLine("Employee is not in the list.\n");
            }
             

            // Finds a specific element in the list based on a condition and displays information of the object
            string findGender = "male";
            Employee foundGender = employeeList.Find(i => i._gender == findGender);

            if (foundGender != null)
            {
                Console.WriteLine($"Employee with ID: {foundGender._Id}, Name: {foundGender._name}, " +
                    $"Gender: {foundGender._gender}, Salary: {foundGender._salary} is found.");
            }
            else
            {
                Console.WriteLine($"Not found: {findGender}");
            }

            // Finds a specific element in the list based on a condition and displays all related information of the object
            string findAllGenders = "male";
            List<Employee> foundAllGenders = employeeList.FindAll(i => i._gender == findAllGenders);

            foreach (Employee item in foundAllGenders)
            {
                Console.WriteLine(item._gender);
                Console.WriteLine($"\nEmployee with ID: {item._Id}, Name: {item._name}, " +
                  $"Gender: {item._gender}, Salary: {item._salary} is found.");
            }     
        }
        class Employee
        {
            public int _Id { get; set; }
            public string _name { get; set; }
            public string _gender { get; set; }
            public int _salary { get; set; }
        }
    }
}


