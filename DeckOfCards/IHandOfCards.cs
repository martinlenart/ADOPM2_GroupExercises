using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartBAnswers_B2
{
    interface IHandOfCards
    {
        /// <summary>
        /// Adds a card into the hand
        /// </summary>
        /// <param name="card"></param>
        void Add(IPlayingCard card);

        /// <summary>
        /// Epmties the hand, i.e. all cards removed
        /// </summary>
        void Clear();
    }
}
