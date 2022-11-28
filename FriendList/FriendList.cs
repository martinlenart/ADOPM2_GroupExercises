using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList
{
    internal class FriendList
    {
        public  List<Friend> myFriends = new List<Friend>();

        public static class Factory
        {
            public static FriendList CreateRandom(int NrOfItems)
            {
                var myList = new FriendList();
                for (int i = 0; i < NrOfItems; i++)
                {
                    myList.myFriends.Add(Friend.Factory.CreateRandom());
                }
                return myList;
            }
        }
    }
}
