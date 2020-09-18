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

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evens = numbers.Where(Utils.IsEven).ToList();

            Assert.Equal(2, evens[0]);
            // etc. etc.


            var five = numbers.SingleOrDefault(x => x == 51);

            Assert.Equal(5, five);

            var david = friends.SingleOrDefault(f => f == "David");

            Assert.Null(david);
            
        }

       
    }
}
