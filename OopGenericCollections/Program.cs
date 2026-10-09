namespace OopGenericCollections;

class Program
{
    static void Main(string[] args)
    {
        // Create five employees 
        Employee employee1 = new Employee();
        employee1.Id = 101;
        employee1.Name = "John";
        employee1.Gender = "Male";
        employee1.Salary = 50000;

        Employee employee2 = new Employee();
        employee2.Id = 102;
        employee2.Name = "Jane";
        employee2.Gender = "Female";
        employee2.Salary = 60000;

        Employee employee3 = new Employee();
        employee3.Id = 103;
        employee3.Name = "Fernando";
        employee3.Gender = "Male";
        employee3.Salary = 40000;

        Employee employee4 = new Employee();
        employee4.Id = 104;
        employee4.Name = "Maria";
        employee4.Gender = "Female";
        employee4.Salary = 55000;

        Employee employee5 = new Employee();
        employee5.Id = 105;
        employee5.Name = "Carlos";
        employee5.Gender = "Male";
        employee5.Salary = 30000;

        
        // Create a stack that holds Employee objects.
        Stack<Employee> employees = new Stack<Employee>();

        // Push adds each employee to the top of the stack.
        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        // Print all employees 
        foreach (Employee person in employees)
        {
            Console.WriteLine(
                $"Id: {person.Id}, Name: {person.Name}, Gender: {person.Gender}, Salary: {person.Salary}");
            Console.WriteLine($"Employees in the stack: {employees.Count}");
        }

        // Keep removing employees until the stack is empty.
        while (employees.Count > 0)
        {
            Employee removedemployee = employees.Pop();

            Console.WriteLine(
                $"Removed employee: {removedemployee.Id}, {removedemployee.Name}, {removedemployee.Gender}, {removedemployee.Salary}");
            Console.WriteLine($"Employees in the stack: {employees.Count}");
        }

        // Add the same employees back to the stack.
        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        // Peek returns the top employee without removing them.
        Employee viewedemployee = employees.Peek();

        Console.WriteLine(
            $"Viewed employee: {viewedemployee.Id}, {viewedemployee.Name}, {viewedemployee.Gender}, {viewedemployee.Salary}");
        Console.WriteLine($"Employees in the stack: {employees.Count}");

        // Peek a second time. Carlos is still on top.
        viewedemployee = employees.Peek();

        Console.WriteLine(
            $"Viewed employee: {viewedemployee.Id}, {viewedemployee.Name}, {viewedemployee.Gender}, {viewedemployee.Salary}");
        Console.WriteLine($"Employees in the stack: {employees.Count}");

        // Check whether employee3 is in the stack.
        Console.WriteLine($"Employee search: {employees.Contains(employee3)}");

        
        // Create a list and add the five employees.
        List<Employee> employeelist = new List<Employee>();

        employeelist.Add(employee1);
        employeelist.Add(employee2);
        employeelist.Add(employee3);
        employeelist.Add(employee4);
        employeelist.Add(employee5);

        // Check whether employee2 is in the list.
        if (employeelist.Contains(employee2))
        {
            Console.WriteLine("Employee2 object exists in the list");
        }
        else
        {
            Console.WriteLine("Employee2 object does not exist in the list");
        }

      
        // Find returns the first match. 
        Employee? firstMale = employeelist.Find(employee => employee.Gender == "Male");
        
        if (firstMale != null)
        {
            Console.WriteLine(
                $"First male employee: {firstMale.Id}, {firstMale.Name}, {firstMale.Gender}, {firstMale.Salary}");
        }
        else
        {
            Console.WriteLine("No male employees found in the list");
        }

        // FindAll returns a list of all employees who match the condition.
        List<Employee> allMales = employeelist.FindAll(employee => employee.Gender == "Male");

        // Print every male employee found.
        foreach (Employee maleEmployee in allMales)
        {
            Console.WriteLine(
                $"Male employee: {maleEmployee.Id}, {maleEmployee.Name}, {maleEmployee.Gender}, {maleEmployee.Salary}");
        }
    }
}