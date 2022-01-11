using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = TypeSyntax;

    public static class TypeSyntaxExtensions
    {
        public static type ToType(this string @this) => ParseTypeName(@this);
    }
}
