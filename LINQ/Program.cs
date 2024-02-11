using LINQ;
using LINQ.Data;

List<Employee> employeeList = Data.GetEmployees();

var filteredEmployees = employeeList.Filter(emp => emp.IsManager == true);

Console.WriteLine("Employees: ");
Console.WriteLine();

foreach (var employee in filteredEmployees)
{
	Console.WriteLine($"First Name: {employee.FirstName}");
	Console.WriteLine($"Last Name: {employee.LastName}");
	Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
	Console.WriteLine($"Manager: {employee.IsManager}");
	Console.WriteLine();


}

List<Department> departmentsList = Data.GetDepartments();

var filteredDepartments = departmentsList.Filter(department => department.ShortName == "HR" || department.ShortName == "FN");

Console.WriteLine("Departments: ");
Console.WriteLine();

foreach (var department in filteredDepartments)
{
	Console.WriteLine($"Id: {department.ID}");
	Console.WriteLine($"ShortName: {department.ShortName}");
	Console.WriteLine($"LongName: {department.LongName}");
	Console.WriteLine();

}

Console.WriteLine("----------------------------------------------");

// We will make a join between two Entities.
// LINQ Query Syntax.

var resultList = from emp in employeeList
				 join dept in departmentsList
				 on emp.DepartmentId equals dept.ID
				 select new
				 {
					 FirstName = emp.FirstName,
					 LastName = emp.LastName,
					 AnnualSalary = emp.AnnualSalary,
					 IsManeger = emp.IsManager,
					 Department = dept.LongName
				 };

foreach (var employee in resultList)
{
	Console.WriteLine($"First Name: {employee.FirstName}");
	Console.WriteLine($"Last Name: {employee.LastName}");
	Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
	Console.WriteLine($"Manager: {employee.IsManeger}");
    Console.WriteLine($"Department: {employee.Department}");
    Console.WriteLine();
}

Console.WriteLine("-----------------------------------------");

var AverageAnnualSalary = resultList.Average(emp => emp.AnnualSalary);
var MaxAnnualSalary = resultList.Max(emp => emp.AnnualSalary);
var MinAnnualSalary = resultList.Min(emp => emp.AnnualSalary);


Console.WriteLine("The Average Annual Salary for all Employees is: " + AverageAnnualSalary);
Console.WriteLine("The Maximum Annual Salary for all Employees is: " + MaxAnnualSalary);
Console.WriteLine("The Minimum Annual Salary for all Employees is: " + MinAnnualSalary);

// LINQ Method Syntax.



Console.ReadKey();
