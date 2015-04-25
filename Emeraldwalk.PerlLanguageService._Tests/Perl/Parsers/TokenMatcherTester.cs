using Emeraldwalk.PerlLanguage.Perl.Parsing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emeraldwalk.PerlLanguageService._Tests
{
    [TestClass]
    public class TokenMatcherTester
    {
        [TestMethod]
        public void MatchesCurlyBraces()
        {
            string text = 
@"helloworld() {
    if(true) {
    }
}";

            TokenMatcher matcher = new TokenMatcher("{", "}");
            matcher.Parse(text);

            Assert.AreEqual(2, matcher.TokenPairs.Count);
        }
    }
}
