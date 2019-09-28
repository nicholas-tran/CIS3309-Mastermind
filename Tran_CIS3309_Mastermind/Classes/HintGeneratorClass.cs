// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_CIS3309_Mastermind
{
    class HintGeneratorClass
    {
        // Attributes
        int[] hiddenHintArray = new int[4];

        // Method to return hiddenHintArray
        public int[] returnHints()
        {
            sortHint();
            return hiddenHintArray;
        }

        // Method to sort hiddenHintArray
        public void sortHint()
        {
            Array.Sort<int>(hiddenHintArray, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
        }

        // Method to set hints into hiddenHintArray
        public void setHint(int[] hints)
        {
            for (int i = 0; i < hiddenHintArray.Length; i++)
            {
                hiddenHintArray[i] = hints[i];
            }
        }
    }
}
