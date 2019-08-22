using NUnit.Framework;

namespace Exercises.Tests
{
    public class MaxSharedPrefixTests
    {
        [Test]
        public void CasesFromTestQuestions()
        {
            Assert.That(
                MaxSharedPrefix.GetMaxSharedPrefix(
                    new[] {"qwe", "qwedfsdf", "qwsdfsdf", "tr"}),
                Is.EqualTo(string.Empty));

            Assert.That(
                MaxSharedPrefix.GetMaxSharedPrefix(
                    new[] {"qwe", "qwedfsdf", "qwsdfsdf"}),
                Is.EqualTo("qw"));

            Assert.That(
                MaxSharedPrefix.GetMaxSharedPrefix(
                    new[] {"qwe", "qeasd", "qwsdfsdf"}),
                Is.EqualTo("q"));
        }
    }
}