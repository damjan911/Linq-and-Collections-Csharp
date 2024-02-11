using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
	public class Employee
	{
		public int Id { get; set; }

		public string FirstName { get; set; } = string.Empty;

		public string LastName { get; set; } = string.Empty;

		public decimal AnnualSalary { get; set; }

		public bool IsManager { get; set; }

		public int DepartmentId { get; set; }
	}
}
