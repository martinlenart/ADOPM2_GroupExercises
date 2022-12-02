using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class CupOfDices : ICupOfDices
    {
        protected int _nrOfDices = 0;
        protected List<IDice> dices = new List<IDice>();

        public IDice this[int idx] => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public IDice Highest => throw new NotImplementedException();

        public IDice Lowest => throw new NotImplementedException();

        public bool IsYahtzee()
        {
            throw new NotImplementedException();
        }

        public void Shake()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        #region ToString() related
        public override string ToString() { return string.Empty; }
        #endregion

        public CupOfDices(int NrOfDices)
        {
            if (NrOfDices < 0 || NrOfDices > 100)
                throw new IndexOutOfRangeException("Wrong number of Dices");

            _nrOfDices = NrOfDices;
            //Shake();
        }
    }
}
