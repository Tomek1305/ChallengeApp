using ChallengeApp;


Employee employee1 = new Employee("Tomek ", "Kowalski", 29 );
Employee employee2 = new Employee("Esther ", "Kowalska ", 24 );
Employee employee3 = new Employee("Lexi ", "Kowalska ", 6 );
Employee employee4 = new Employee("Emilia ", "Kowalska ", 3 );

employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(1);
employee1.AddScore(6);

employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(2);

employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(6);

employee4.AddScore(1);
employee4.AddScore(5);
employee4.AddScore(6);
employee4.AddScore(4);
employee4.AddScore(3);

List<Employee>  employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4,
};
int maxresult = -1;
Employee employeeWithMaxResult = null;  

foreach(var employee in employees)
{
    if(employee.Result  > maxresult)
    {
        maxresult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
foreach (var employee in employees)
{
    if (employee.Result == maxresult)
    {
        Console.WriteLine("Najwięksaz ilość punktów zdobył(a) " + employee.name + employee.surname  + "lat " + employee.age  + " Uzyskał(a) " + employee.Result + " punktów");
    }
}
  