using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class DeckOfCards : IDeckOfCards
    {
        public IPlayingCard this[int idx] => throw new NotImplementedException();

        #region ToString() related
        public override string ToString() { return string.Empty; }
        #endregion

        public IPlayingCard DealOne()
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
