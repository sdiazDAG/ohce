using System;
using Xunit;

namespace ohce
{
    public class OhceShould
    {
        [Fact]
        public void Prints_same_word_if_palyndrome()
        {
            const string word = "oso";
            string expectedWord = word;

            string currentWord = Ohce.Answer(word);

            Assert.Equal(expectedWord, currentWord);
        }
    }

    public class Ohce
    {
        public static string Answer(string word)
        {
            return word;
        }
    }
}
