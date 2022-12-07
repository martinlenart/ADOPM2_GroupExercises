namespace IEquatable_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>();
            for (int i = 0; i < 100; i++)
            {
                persons.Add(Person.Factory.CreateRandom());
            }

            var aPerson = new Person((Person) persons[0]);
            Console.WriteLine(persons.Contains(aPerson));

            persons.Sort();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}