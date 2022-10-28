using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryExample.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        private readonly string startsWithUpper = "Aaaa";
        private readonly string startsWithLower = "aaaa";
        private readonly string startsWithDigit = "0aaaa";

        private readonly string endsWithUpper = "aaaaA";
        private readonly string endsWithLower = "aaaaa";
        private readonly string endsWithDigit = "aaaa0";

        private readonly string emptyString = String.Empty;

        [TestMethod()]
        public void StartsWithLetterTest()
        {
            Assert.IsTrue(startsWithUpper.StartsWithLetter());
            Assert.IsTrue(startsWithLower.StartsWithLetter());
            Assert.IsFalse(startsWithDigit.StartsWithLetter());
            Assert.IsFalse(emptyString.StartsWithLetter());
        }

        [TestMethod()]
        public void StartsWithUpperTest()
        {
            Assert.IsTrue(startsWithUpper.StartsWithUpper());
            Assert.IsFalse(startsWithLower.StartsWithUpper());
            Assert.IsFalse(startsWithDigit.StartsWithUpper());
            Assert.IsFalse(emptyString.StartsWithUpper());
        }

        [TestMethod()]
        public void StartsWithLowerTest()
        {
            Assert.IsFalse(startsWithUpper.StartsWithLower());
            Assert.IsTrue(startsWithLower.StartsWithLower());
            Assert.IsFalse(startsWithDigit.StartsWithLower());
            Assert.IsFalse(emptyString.StartsWithLower());
        }

        [TestMethod()]
        public void StartsWithDigitTest()
        {
            Assert.IsFalse(startsWithUpper.StartsWithDigit());
            Assert.IsFalse(startsWithLower.StartsWithDigit());
            Assert.IsTrue(startsWithDigit.StartsWithDigit());
            Assert.IsFalse(emptyString.StartsWithDigit());
        }

        [TestMethod()]
        public void EndsWithLetterTest()
        {
            Assert.IsTrue(endsWithUpper.EndsWithLetter());
            Assert.IsTrue(endsWithLower.EndsWithLetter());
            Assert.IsFalse(endsWithDigit.EndsWithLetter());
            Assert.IsFalse(emptyString.EndsWithLetter());
        }

        [TestMethod()]
        public void EndsWithUpperTest()
        {
            Assert.IsTrue(endsWithUpper.EndsWithUpper());
            Assert.IsTrue(endsWithLower.EndsWithUpper());
            Assert.IsFalse(endsWithDigit.EndsWithUpper());
            Assert.IsFalse(emptyString.EndsWithUpper());
        }
    }
}