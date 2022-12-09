// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace FriendListDelegateEvent // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFriendList - friends1");
            var friends1 = FriendList.Factory.CreateRandom(10, SameName);
            Console.WriteLine(friends1);

            Console.WriteLine("\nFriendList - friends2");
            var friends2 = FriendList.Factory.CreateRandom(5, SameCity);
            Console.WriteLine(friends2);

            var friends3 = FriendList.Factory.CreateRandom(100);

            Console.WriteLine("\nHello to Finland");
            friends3.SayHello(HelloFinland);

            Console.WriteLine("\nHello to Gavle");
            friends3.SayHello(HelloGavle);

            Console.WriteLine("\nHello to Scandinavia");
            friends3.SayHello(HelloScandinavia);

            /*
            Console.WriteLine("\nHuge friendlist");
            FriendList.CreationProgress += ProgressReport;
            var hugeNrFriends = FriendList.Factory.CreateRandom(1_000_000);
            */
        }

        //Exercise
        //1. Instead of using the delegates SameName, SameCity, HelloFinland, HelloGavle, HelloScandinavia
        //   use LambdaExpressions directly in the method call where the delegate is used
        //2. Instead of using the Eventhandler ProgressReport, use a LambdaExpression directly in the event handler
        //   assignment

        public static void ProgressReport(int completion)
        {
            Console.WriteLine($"completed {completion} number");
        }
        public static void HelloFinland(Friend friend)
        {
            if (friend.Address.Country == "Finland")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.Country} from Finland");
            }
        }
        public static void HelloGavle(Friend friend)
        {
            if (friend.Address.City == "Gavle")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.City} from Gavle");
            }
        }
        public static void HelloScandinavia(Friend friend)
        {
            if (friend.Address.Country != "Finland")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.Country} from Scandinavia");
            }
        }


        public static Friend SameName(Friend orgFriend)
        {
            orgFriend.FirstName = "Jane";
            return orgFriend;
        }

        public static Friend SameCity(Friend orgFriend)
        {
            var newAddress = orgFriend.Address;
            newAddress.City = "Gavle";

            orgFriend.Address = newAddress;
            return orgFriend;
        }
    }
}