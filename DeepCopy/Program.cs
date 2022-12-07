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

        //Write code for Deep copy of a friend
 
        //List of persons
        Person[] list = new Person[20];
        for (int i = 0; i < list.Length; i++)
        {
            list[i] = Person.Factory.CreateRandom();
        }

        //Shallow list copy
        Person[] people = new Person[20];
        Array.Copy(list, people, list.Length);

        list[0].FirstName = "Donald";
        list[0].LastName = "Duck";
        Console.WriteLine(list[0]);
        Console.WriteLine(people[0]);

        //write code for Deep list copy
      }
}

