namespace GenericCollections
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    // Generic Collections.

			//List<int> primeNumbers = new List<int>();

			//primeNumbers.Add(1);
			//primeNumbers.Add(2);
			//primeNumbers.Add(3);
			//primeNumbers.Add(4);
			//primeNumbers.Add(5);
			//primeNumbers.Add(6);

			//foreach (int primeNumber in primeNumbers)
			//{
			//	Console.WriteLine(primeNumber);
			//}


			//var students = new List<Student>()
			//{
			//	new Student() {Id = 1, Name = "Bill"},
			//	new Student() {Id = 2, Name = "Steve"},
			//	new Student() {Id = 3, Name = "Ram"},
			//	new Student() {Id = 4, Name = "Abdul"}

			//};

			//foreach (Student student in students)
			//{
			//	Console.WriteLine($" The Student Name is: { student.Name}");
			//}


			//string[] cities = new string[3] {"Mumbai","London","New York"};

			//var popularCities = new List<string>();

			//// Add Arrays in List.
			//popularCities.AddRange(cities);

			//foreach(String city in popularCities)
			//{
			//	Console.WriteLine(city);
			//}


			//var numbers = new List<int>() {10,20,30,40,50,60};

			//numbers.Insert(1, 15);

			//foreach(int i in numbers)
			//{
			//	Console.WriteLine(i);
			//}


			// Dictionary Generic Collection.

			IDictionary<string,string> metropolitCities = new Dictionary<string, string>()
			{
				{"UK", "London, Manchester, Birmingham"},
	            {"USA", "Chicago, New York, Washington"},
	            {"India", "Mumbai, New Delhi, Pune"}
			};

			//foreach (var citie in metropolitCities)
			//{
            //  Console.WriteLine(citie);
            //}

			// Access Dictionary Elements.

			// Console.WriteLine($"The USA Cities are: { metropolitCities["USA"]}");

			// Update Dictionary Elements.

			metropolitCities["USA"] = "Los Angeles,Boston";

			if (metropolitCities.ContainsKey("USA"))
			{
                Console.WriteLine($"Updated USA Cities{ metropolitCities["USA"]}");

            }


			// Dictionary Wishing List.

			Dictionary<string, List<string>> wishList = new()
			{
				{"Tim Corey",new List<string> {"Xbon","Tesla","Pizza"}},
				{"Billy Bob",new List<string> {"PS5","Ford","IPhone"}},
				{"Mary Jane",new List<string> {"House","Car","Sub"}}

			};

			foreach (var item in wishList)
			{
                Console.WriteLine(item);
            }


			Console.ReadKey();
		}
	}
}