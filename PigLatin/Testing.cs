using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class Testing
    {




        [Fact]
        public void TestPigLatinApple()
        {
            PigLatinMethods p = new PigLatinMethods();
            
            string expected = "appleway";
            
            string actual = p.ToPigLatin("apple");

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]
        public void TestPigLatin(string word, string expected)
        {
            PigLatinMethods p = new PigLatinMethods();

            string actual = p.ToPigLatin(word);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData('a', "")]
        [InlineData('e', "")]
        [InlineData('i', "")]
        [InlineData('o', "")]
        [InlineData('u', "")]
        [InlineData('q', "")]
        [InlineData('w', "")]
        public void TranslateVowels(char letter, string expected)
        {
            PigLatinMethods v = new PigLatinMethods();

            bool actual = v.IsVowel(letter);

            Assert.True(actual,expected );
        }
    }
}
