using System;
using System.Collections.Generic;
using Helpers;

namespace M3_Yahtzee
{
    //Sprint 2
    /// <summary>
    /// Cup with 1 to 10 dice
    /// </summary>

    
    class csCupOfDice : ICupOfDice
    {
        csSeedGenerator _rnd = new csSeedGenerator();

        protected List<enDiceFace> _dices = new List<enDiceFace>();
        public int Count => _dices.Count;


        public csCupOfDice(int NrOfDices)
        {
            if (NrOfDices < 1 || NrOfDices > 10)
            {
                throw new ArgumentException("Number of dice must be between 1 and 10.");
            }

        }
    }
    
}
