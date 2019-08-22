using System;
using NUnit.Framework;

namespace Exercises.Tests
{
    public class TwoNumbersByTheirSumTests
    {
        [Test]
        public void SomeSimpleCases()
        {
            Assert.That(
                TwoNumbersByTheirSum.HasTwoNumbersWhichInTotalGivePassedSum(
                    new []{ 1, 2 },
                    3),
                Is.True);
            
            Assert.That(
                TwoNumbersByTheirSum.HasTwoNumbersWhichInTotalGivePassedSum(
                    new []{ 15, 357, 2, 73, 352 },
                    3),
                Is.False);
            
            Assert.That(
                TwoNumbersByTheirSum.HasTwoNumbersWhichInTotalGivePassedSum(
                    new []{ 15, 357, 2, 73, 352 },
                    709),
                Is.True);
            
            Assert.That(
                TwoNumbersByTheirSum.HasTwoNumbersWhichInTotalGivePassedSum(
                    new []{ 3, 14, 423, 1 },
                    3),
                Is.False);
            
            Assert.That(
                TwoNumbersByTheirSum.HasTwoNumbersWhichInTotalGivePassedSum(
                    new []{ 7, 15, 25, 37, 3, 21, 43 },
                    36),
                Is.True);
        }
        
        [Test]
        [Obsolete("Should be removed when slow method version is removed.")]
        public void CompareWithSlowMethod()
        {
            for (var i = 0; i < 200; i++)
            {
                var fastMethodResult = TwoNumbersByTheirSum
                    .HasTwoNumbersWhichInTotalGivePassedSum(
                        new[] {7, 15, 25, 37, 3, 21, 43},
                        i);
                
                var slowMethodResult = TwoNumbersByTheirSum
                    .HasTwoNumbersWhichInTotalGivePassedSum_Slow(
                        new[] {7, 15, 25, 37, 3, 21, 43},
                        i);

                Assert.That(fastMethodResult, 
                    Is.EqualTo(slowMethodResult));
            }
        }
    }
}