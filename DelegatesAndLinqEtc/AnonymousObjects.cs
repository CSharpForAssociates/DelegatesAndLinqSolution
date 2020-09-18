using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public class AnonymousObjects
    {
        [Fact]
        public void UsingThem()
        {
            var movie = new { Title = "Jaws", Director = "Spielberg", YearReleased = 1977 };


            Assert.Equal("Jaws", movie.Title);
            

            var manager = GetManager();
            // No Properties

            var numbers = new List<int> { 1, 2, 3, 4 };
            var numbersDoubledAndTurnedIntoStrings = numbers.Select(n => new { Original = n, Doubled = (n * 2).ToString() }).ToList();

            Assert.Equal("2", numbersDoubledAndTurnedIntoStrings[0].Doubled);
            Assert.Equal(1, numbersDoubledAndTurnedIntoStrings[0].Original);
            Assert.Equal("4", numbersDoubledAndTurnedIntoStrings[1].Doubled);
            Assert.Equal(2, numbersDoubledAndTurnedIntoStrings[1].Original);
            // etc. etc.
        }

        public object GetManager()
        {
            return new { Name = "Karen", Phone = "555-1212" };
        }
    }
}
