using System;
using buildr;

List<Employee> empl = new()
{
    new Employee{ Name = "Boris", Salary = 2101200 },
    new Employee { Name = "Bebra", Salary = 210200 }
};

var builer = new EmployeeReportBuilder(empl);

var director = new EmployeeReportDirector(builer);

director.Build();

var report = builer.GetReport();

Console.WriteLine(report);

