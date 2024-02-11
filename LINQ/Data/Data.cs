using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data
{
	public static class Data
	{
		public static List<Employee> GetEmployees()
		{
			var employees = new List<Employee>()
			{
				new Employee()
				{
					Id = 1,
					FirstName = "Bob",
					LastName = "Jones",
					AnnualSalary = 60000.3m,
					IsManager = true,
					DepartmentId = 1
				},

				new Employee()
				{
					Id = 2,
					FirstName = "Sarah",
					LastName = "Jameson",
					AnnualSalary = 80000.1m,
					IsManager = true,
					DepartmentId = 2
				},
				new Employee()
				{
					Id = 3,
					FirstName = "Douglas",
					LastName = "Roberts",
					AnnualSalary = 40000.2m,
					IsManager = false,
					DepartmentId = 2
				},
				new Employee()
				{
					Id = 4,
					FirstName = "Jane",
					LastName = "Stevens",
					AnnualSalary = 30000.2m,
					IsManager = false,
					DepartmentId = 3
				} 
			};

			return employees;
		}

		public static List<Department> GetDepartments()
		{
			var departments = new List<Department>()
			{
				new Department 
				{
					ID = 1,
					ShortName = "HR",
					LongName = "Human Resources"
				},
				new Department
				{
					ID = 2,
					ShortName = "FN",
					LongName = "Finance"
				},
				new Department
				{
					ID = 3,
					ShortName = "TE",
					LongName = "Technology"
				}
			};

			return departments;
		}
	}
}

