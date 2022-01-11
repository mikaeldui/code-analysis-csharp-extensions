using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = StatementSyntax;

    public static class StatementSyntaxExtensions
    {
        public static BlockSyntax ToBlock(this type @this) => Block(@this);

        public static type ToStatement(this string @this) => ParseStatement(@this);
    }
}
