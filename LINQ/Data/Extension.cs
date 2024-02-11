using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data
{
	public static class Extension
	{
		// The First Parameter represents the list of records that you want to filter.
		// The Second Parameter returns boolean indicating whether the element should be included in the filtered list.
		public static List<T> Filter<T>(this List<T> records, Func<T, bool> filter)
		{
			List<T> filteredList = new List<T>();

			foreach (T record in records)
			{
				if (filter(record))
				{
					filteredList.Add(record);
				}
			}

			return filteredList;
		}
	}
}
