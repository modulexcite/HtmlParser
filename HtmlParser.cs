using System;
using System.Collections.Generic;

namespace ClassLibrary3
{
    internal class HtmlParser
    {
        public static IEnumerable<HtmlNode> Parse(string html)
        {
            IEnumerable<Token> tokens = TokenParser.ParseTokens(html);
            return TreeBuilder.BuildTree(tokens);
        }
    }
}