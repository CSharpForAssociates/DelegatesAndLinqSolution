using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;

namespace DelegatesAndLinqEtc
{
    public class NumberGenerator
    {
        public IEnumerable<int> GetNumbersOneToOneHundred()
        {
            
            for(var n = 1; n<101; n++)
            {
                Thread.Sleep(100);
                yield return n;
            }
           
        }

        public IEnumerable<string> FavoriteMovies()
        {
            yield return "Shadows";
            yield return "Faces";
            yield return "The Killing of the Chinese Bookie";
            yield return "Love Streams";
        }
    }
}
