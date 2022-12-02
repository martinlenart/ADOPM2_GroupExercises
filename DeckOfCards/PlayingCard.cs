using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public class PlayingCard: IPlayingCard
	{
        public PlayingCardSuit Suit { get; init; }
        public PlayingCardValue Value { get; init; }

        #region IComparable Implementation
        //Need to compare not only Value but also Color if value is the same
        public int CompareTo(IPlayingCard other)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ToString() related
        public override string ToString() => $"";
        #endregion
    }
}
