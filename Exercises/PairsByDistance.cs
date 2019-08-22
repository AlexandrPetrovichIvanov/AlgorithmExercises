using System.Collections.Generic;

namespace Exercises
{
    public static class PairsByDistance
    {
        public static Dictionary<int, int> GetPairs(IEnumerable<int> numbers, int distance)
        {
            var buffer = new Queue<int>();
            
            var result = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                // fill queue to desired distance
                if (buffer.Count < distance + 1)
                {
                    buffer.Enqueue(number);
                    continue;
                }

                var numberOnGivenDistance = buffer.Dequeue();

                if (numberOnGivenDistance == number)
                {
                    result.TryGetValue(number, out var previous);
                    result[number] = ++previous;
                }
                
                buffer.Enqueue(number);
            }

            return result;
        }
    }
}