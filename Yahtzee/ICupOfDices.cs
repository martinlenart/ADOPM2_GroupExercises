using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    interface ICupOfDices
    {
        /// <summary>
        /// Nr of Dices in the cup
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// The value of a specific dice
        /// </summary>
        /// <param name="idx">Dice: 0 to Count-1</param>
        /// <returns>The value of dice with idx. Throws IndexOutOfRangeException for invalid idx and if Count is 0
        /// </returns>
        public DiceFace this[int idx] { get; }

        /// <summary>
        /// Get the DiceFace of the highest Dice in the cup. Throws IndexOutOfRangeException if Count is 0
        /// </summary>
        public DiceFace Highest { get; }

        /// <summary>
        /// Get the DiceFace of the lowest Dice in the cup. Throws IndexOutOfRangeException if Count is 0
        /// </summary>
        public DiceFace Lowest { get; }

        /// <summary>
        /// Sort the dices in the cup in ascending order
        /// </summary>
        public void Sort();

        /// <summary>
        /// Shake the cup and create new random DiceFaces.
        /// </summary>
        public void Shake();

        /// <summary>
        /// Yahtzee = all  dices have the same FaceValue
        /// </summary>
        public bool IsYahtzee();

        //ToString()
        //Should override ToString() to print out the bucket of dices

        //Constructors, Should contain two constructors
        //Constructor () : creates an empty cup with no Dices.
        //Constructor (int NrOfDices) : Nr of Dices in the cup, Maximum 100
    }
}
