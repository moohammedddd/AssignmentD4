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

        }
    }
}
