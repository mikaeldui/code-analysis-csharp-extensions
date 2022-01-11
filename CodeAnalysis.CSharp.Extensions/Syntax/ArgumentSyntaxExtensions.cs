using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = ArgumentSyntax;
    using typeList = ArgumentListSyntax;

    public static class ArgumentSyntaxExtensions
    {
        public static type ToArgument(this string @this) => Argument(IdentifierName(@this));
                
        public static IEnumerable<type> ToArguments(this IEnumerable<string> @this) => @this.Select(t => t.ToArgument());

        public static type[] ToArguments(this string[] @this) => ((IEnumerable<string>)@this).ToArguments().ToArray();
        
        public static typeList ToArgumentList(this IEnumerable<string> @this) => ArgumentList(SeparatedList(@this.ToArguments()));
    }
}
