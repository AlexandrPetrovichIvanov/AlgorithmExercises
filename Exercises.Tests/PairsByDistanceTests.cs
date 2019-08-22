using NUnit.Framework;

namespace Exercises.Tests
{
    public class PairsByDistanceTests
    {
        [Test]
        public void CaseFromTestQuestions()
        {
            var pairs = PairsByDistance.GetPairs(
                new[] {1, 3, 1, 3, 1, 3, 8, 8, 3},
                1);
            
            Assert.That(pairs[1] == 2);
            Assert.That(pairs[3] == 2);
            Assert.That(pairs.Keys.Count == 2);
        }
    }
}