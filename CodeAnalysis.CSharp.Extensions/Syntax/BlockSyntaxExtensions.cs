using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = BlockSyntax;
    public static class BlockSyntaxExtensions
    {
        public static type ToBlock(this string @this) => Block(ParseStatement(@this));
    }
}
