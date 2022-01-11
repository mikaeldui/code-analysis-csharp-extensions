using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = NameSyntax;

    public static class NameSyntaxExtensions
    {
        public static type ToName(this string @this) => ParseName(@this);
    }
}
