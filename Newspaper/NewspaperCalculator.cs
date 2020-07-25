using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal static class NewspaperCalculator
    {
        internal static int CalcNumberOfChars(Newspaper newspaper)
        {
            int sum = 0;
            for (int i = 0; i < newspaper.GetStories().Length; i++)
            {
                sum = sum + newspaper.GetStories()[i].GetTitle().Length + newspaper.GetStories()[i].GetBody().Length;
            }
            return sum;
        }
    }
}
