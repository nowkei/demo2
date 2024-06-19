using SRP_SOLID;

class Program
{
    static void Main(string[] args)
    {
        IEmployeeStorage storage = new FileEmployeeStorage();
        EmployeeManager manager = new EmployeeManager(storage);

        manager.AddEmployee(new Employee { Id = 5, Name = "Thai Thum Thum", Age = 25 });
        manager.AddEmployee(new Employee { Id = 6, Name = "No Dua", Age = 26 });
        var employees = manager.GetAllEmployees();
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}");
        }

        Employee employeeToDelete = employees.Find(emp => emp.Id == 5);
        manager.DeleteEmployee(employeeToDelete);
        employees = manager.GetAllEmployees();
        Console.WriteLine("dsach moi:");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}");
        }
    }
}