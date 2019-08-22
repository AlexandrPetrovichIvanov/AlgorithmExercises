using System;
using System.Collections.Generic;

namespace Exercises
{
    public static class MaxSharedPrefix
    {
        public static string GetMaxSharedPrefix(IEnumerable<string> words)
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words));
            
            string maxSharedPrefix = null;

            var isFirstIteration = true;

            foreach (var word in words)
            {
                if (isFirstIteration)
                {
                    isFirstIteration = false;
                    maxSharedPrefix = word;
                    continue;
                }

                maxSharedPrefix = GetCommonPrefix(maxSharedPrefix, word);
                
                // we can return empty string
                // immediately if there are two different strings
                // there IS two different strings because this is
                // not the first iteration
                if (string.IsNullOrEmpty(maxSharedPrefix))
                    return string.Empty;
            }

            return maxSharedPrefix;
        }

        private static string GetCommonPrefix(string word1, string word2)
        {
            var sharedLength = Math.Min(word1.Length, word2.Length);

            for (var i = 0; i < sharedLength; i++)
            {
                if (word1[i] != word2[i])
                {
                    if (i == 0) return "";

                    return word1.Substring(0, i);
                }
            }

            return word1.Substring(0, sharedLength);
        }
    }
}