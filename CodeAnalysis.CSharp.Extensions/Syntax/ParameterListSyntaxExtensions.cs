using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = ParameterListSyntax;

    public static class ParameterListSyntaxExtensions
    {
        public static type ToParameterList(this IEnumerable<KeyValuePair<string, string>> @this) =>
            ParameterList(SeparatedList(@this.ToParameters()));

        public static type ToParameterList(this (string identifier, string type) @this) =>
            @this.ToParameter().ToParameterList();
    }
}
