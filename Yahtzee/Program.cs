namespace Yahtzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test creating a couple of Dice
            IDice dice1 = null;
            IDice dice2 = null;
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);

            //Test creating an empty cup
            ICupOfDices cup1 = null;
            Console.WriteLine(cup1);

            //Test creating a cup with 5 dice
            ICupOfDices cup2 = null;
            Console.WriteLine(cup2);

            //Shake the cup
            //cup2.Shake();
            Console.WriteLine(cup2);

            //Sort the cup
            //cup2.Sort();
            Console.WriteLine(cup2);

            //check if you have Yahtzee
            //Console.WriteLine(cup2.IsYahtzee());

        }
    }
}