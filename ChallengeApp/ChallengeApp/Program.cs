
using ChallengeApp;


Employee employee1 = new Employee("Adam1" ,"Kowalksa" , 20);
Employee employee2 = new Employee("Paweł", "Kowlaski", 23);
Employee employee3 = new Employee("Zuzia", "Kowalska", 22);



employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(5);

employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(5);

employee3.AddScore(5);
employee3.AddScore(2);
employee3.AddScore(7);

List <Employee>employees = new List<Employee>()
{
    employee1, employee2, employee3,
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (Employee employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("dane pracownika:" + employeeWithMaxResult.Name + employeeWithMaxResult.Surename + employeeWithMaxResult.Age );
Console.WriteLine("Największy wynik:" + employeeWithMaxResult.Result);


