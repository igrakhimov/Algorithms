using System;

namespace Algorithms
{
    public class Chapter1
    {
        static void Main()
        {
            Collection names = new Collection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            foreach (var name in names)
            {
                Console.WriteLine("Number of names: " + names.Count());
                names.Remove("Raymond");
                Console.WriteLine("Number of names: " + names.Count());
                names.Clear();
                Console.WriteLine("Number of names: " + names.Count());
            }
        }
    }
}