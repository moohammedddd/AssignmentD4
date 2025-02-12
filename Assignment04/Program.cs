using System.Collections;
namespace Assignment04
{
    internal class Program
    {
        class StringEqualityComparer : IEqualityComparer
        {
            public new bool Equals(object? x, object? y)
            {
                string? xString = x as string;
                string? yString = y as string;

                return xString.ToLower() == yString.ToLower();
            }

            public int GetHashCode(object obj)
            {
                string ObjString = obj as string;
                if (ObjString is null)
                {
                    throw new ArgumentException("object is not string");
                }
                return ObjString.ToLower().GetHashCode();
            }

        }

        class StringEqualityComparerDictionary : IEqualityComparer<string>
        {
            public new bool Equals(string? x, string? y)
            {
                //string? xString = x as string;
                //string? yString = y as string;

                return x.ToLower() == y.ToLower();
            }

            public int GetHashCode(string? other)
            {
                //  string ObjString = obj as string;
                if (other is null)
                {
                    throw new ArgumentException("object is not string");
                }
                return other.ToLower().GetHashCode();
            }

        }

        class StringDescComparer : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return y?.CompareTo(x) ?? (x is not null ? 0 : -1);
            }

        }
        static void Main(string[] args)
        {
            #region Hashtable NonGeneric
            #region intro
            // this is collection of key value key should be unique 
            // in non generic version key of type object and value of type object 
            // in generic version (dictionary) i detect the type of value 
            // hash table is very fast O(1) 
            // keys should  be immutable and unique 
            //Hashtable Note = new Hashtable()
            //{
            //    ["Ahmed"] = 555,
            //    ["Mohamed"] = 444,
            //    ["Omar"] = 666
            //};

            //Console.WriteLine($"{Note["Ahmed"]}");

            //Console.WriteLine($"{Note["Ali"] ?? "not found"}"); // will return null if key is not represented
            #endregion

            #region Loop in HashTable
            //Hashtable Note = new Hashtable()
            //{
            //    ["Ahmed"] = 555,
            //    ["Mohamed"] = 444,
            //    ["Omar"] = 666
            //};
            //foreach (DictionaryEntry Person in Note)
            //{
            //    Console.WriteLine($"the name is {Person.Key} number is {Person.Value}");
            //}
            //foreach (var name in Note.Keys)
            //{
            //    Console.WriteLine($"the name is {name} "); // to print keys 
            //}
            //foreach (var value in Note.Values)
            //{
            //    Console.WriteLine($"the value is {value} "); // to print keys 
            //}
            #endregion

            #region Add , Get , Set
            // it is unsafe code 
            // Note.Add("Ahmed", 10); // will throw exception because key is unique 
            // it also throw exception !!
            //Hashtable Note = new Hashtable()
            //{
            //    ["Ahmed"] = 555,
            //    ["Mohamed"] = 444,
            //    ["Omar"] = 666
            //};

            //if (!Note.ContainsKey("Ahmed"))
            //{
            //    Note.Add("Ahmed", 15);
            //}
            //if (!Note.ContainsKey("Ahmed")) // updates and check to avoid throw exception 
            //{
            //    Note["yasmeen"] = 222;
            //}
            // in Dictionary i have try Add
            #endregion

            #region Construcotr
            //Hashtable Note = new Hashtable(10, 0.72f, new StringEqualityComparer())
            // {

            //{ "Ahmed", 1 },
            //{ "Mohamed", 2 },
            //{ "Mostafa", 3 }

            // };
            //Note.Add("ahmed", 4); // it will adding ahmed  after make Icomparable it will throw exception
            #endregion

            #region Methods 
            //Hashtable Notes = new Hashtable()
            //{
            //    ["ahmed"] = 555,
            //    ["mohamed"] = 444,
            //    ["mostafa"] = 666
            //};
            //foreach (var i in Notes.Keys)
            //{
            //    Console.WriteLine(i);
            //}

            //Notes.Clear();
            #endregion


            #endregion

            #region Generic Dictionary
            #region Intro
            //KeyValuePair<string, int>[] keyValuePairs = new KeyValuePair<string, int>[3]
            //{
            //        new KeyValuePair<string, int>("Mohaed",50),
            //        new KeyValuePair<string, int>("Hassan",50),
            //        new KeyValuePair<string, int>("Mahmoud",50),

            //};
            //Dictionary<string, int> Note = new Dictionary<string, int>
            //        {
            //    { "Ahamed", 15 },
            //    { "Mohamed", 16 },
            //    { "Mostafa", 17 }
            //};
            //Dictionary<string, int> Note01 = new Dictionary<string, int>(Note, new StringEqualityComparerDictionary());

            //foreach (var Person in Note.Values) Console.WriteLine($"{Person}");
            //foreach (var Person in Note.Keys) Console.WriteLine($"{Person}");
            //foreach (var Person in Note) Console.WriteLine($"{Person.Key} {Person.Value}");

            //Dictionary<string, int> Notes02 = new Dictionary<string, int>(keyValuePairs);
            //foreach (var Person in Notes02) Console.WriteLine($"{Person.Key} {Person.Value}");

            #endregion

            #region Method
            #region Add
            //  Dictionary<string, int> Note = new Dictionary<string, int>
            //          {
            //      { "Ahamed", 15 },
            //      { "Mohamed", 16 },
            //      { "Mostafa", 17 }
            //  };
            // // Note.Add("Ali", 560); // it is unsafe code
            //  if (!Note.ContainsKey("Ali"))
            //  {
            //      Note.Add("Ali", 50);
            //  }
            //  foreach (var Person in Note) Console.WriteLine($"{Person.Key} {Person.Value}"); // ali was added

            ////  OR Use Try Add
            //   Note.TryAdd("Ali", 640);// it will return bool 

            //  //Set
            //  Console.WriteLine($"{Note["Ahmed"]}"); // if ahmed not found it throw exception (unsafe code)
            #endregion

            #region Get
            //Dictionary<string, int> Note = new Dictionary<string, int>
            //          {
            //      { "Ahamed", 15 },
            //      { "Mohamed", 16 },
            //      { "Mostafa", 17 }
            //  };
            //if (Note.ContainsKey("Ahamed"))
            //{
            //    Console.WriteLine($"{Note["Ahamed"]}");
            //}

            //// Can use TryGet 
            //Note.TryGetValue("mohamed", out int value); // return bool
            //Console.WriteLine(value);
            #endregion

            #region Set
            //Dictionary<string, int> Note = new Dictionary<string, int>
            //          {
            //      { "Ahamed", 15 },
            //      { "Mohamed", 16 },
            //      { "Mostafa", 17 }
            //  };
            //Note["Ahamed"] = 22;
            //foreach (var Person in Note) Console.WriteLine($"{Person.Key} {Person.Value}");
            //Note.Add("ahamed", 55); // then it will throw exception 
            #endregion
            #region Dictionary with Employee
            //Employee employee01 = new Employee(10, "Ahmed", 550);
            //Employee employee02 = new Employee(15, "Mohamed", 20);
            //Employee employee03 = new Employee(16, "Mostafa", 30);
            //Dictionary<Employee, string> employees = new Dictionary<Employee, string>
            //{
            //    [employee01] = "Employee With Id: 10, Name Ahmed , Salary 550",
            //    [employee02] = "Employee With Id: 10, Name Mohamed, Salary 20",
            //    [employee03] = "Employee With Id: 10, Name Mostafa , Salary 30",
            //};

            //foreach (var employee in employees) Console.WriteLine($"{employee.Key}");

            //employees.Add(new Employee(10, "Ahmed", 550), string.Empty); // It Will Throw Exception
            #endregion

            #region SortedDictionary [Binary Search Tree]
            //SortedDictionary<string, int> SortedNote = new SortedDictionary<string, int>(new StringDescComparer());
            //SortedNote.Add("Ahmed", 888);
            //SortedNote.Add("Mohamed", 777);
            //SortedNote.Add("Mostafa", 444);
            //foreach (var person in SortedNote) Console.WriteLine(person); // it will sorted by default
            //// i want to reflect the oreder then make constructor to reflect icmparable 
            #endregion


            #region Example01
           // sort it based on salary "Note it in database "
            //SortedDictionary<Employee, string> SortedNote = new SortedDictionary<Employee, string>()
            //{
            //    { new Employee(10, "Ahmed", 550), "Employee With Id: 10, Name Ahmed, Salary 550" },
            //    { new Employee(11, "Mohamed", 20), "Employee With Id: 11, Name Mohamed, Salary 20" },
            //    { new Employee(12, "zahe", 5650), "Employee With Id: 12, Name Ahmedd, Salary 5650" }
            //};

            //foreach (var employee in SortedNote)
            //    Console.WriteLine(employee.Key);
            #endregion
            #endregion

            #endregion

        }
    }
}
