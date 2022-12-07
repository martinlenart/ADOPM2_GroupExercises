namespace DeepCopy;
class Program
{
    static void Main(string[] args)
    {
        IPerson aFriend = Person.Factory.CreateRandom();
        Console.WriteLine(aFriend);

        //Shallow copy of a friend
        IPerson anotherFriend = aFriend;
        Console.WriteLine(anotherFriend);

        aFriend.FirstName = "Donald";
        aFriend.LastName = "Duck";
        Console.WriteLine(anotherFriend);

        //Write code for Deep copy of afriend
        //Your code


        //List of persons
        Person[] persons = new Person[20];
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = Person.Factory.CreateRandom();
        }

        //Shallow list copy
        Person[] people = new Person[20];
        Array.Copy(persons, people, persons.Length);

        persons[0].FirstName = "Donald";
        persons[0].LastName = "Duck";
        Console.WriteLine(persons[0]);
        Console.WriteLine(people[0]);

        //write code for Deep list copy of list
        //Your code

      }
}

