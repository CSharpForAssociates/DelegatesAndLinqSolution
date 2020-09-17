using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DelegatesAndLinqEtc.Stuff;
using System.Linq;
using Xunit.Abstractions;

namespace DelegatesAndLinqEtc
{
    public class ExtensionMethods
    {

        ITestOutputHelper _output;

        public ExtensionMethods(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TheCase()
        {
            int someNumber = 12;
           
            if (someNumber.IsEven())
            {
                // it is even
            }
            else
            {
                // it is odd.
            }


            var nextWeek = 7.DaysFromNow();

            var friends = new List<string> { "Sean", "Tim", "Sue" };

            var threeLetteredNames = friends.Where(x => x.Length == 3);

            friends.Add("Jim");
            

            foreach(var friend in threeLetteredNames)
            {
                _output.WriteLine(friend);
            }
            
        }

       
    }
}
