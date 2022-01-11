using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = ParameterSyntax;
    using typeList = ParameterListSyntax;

    public static class ParameterSyntaxExtensions
    {
        public static typeList ToParameterList(this ParameterSyntax parameter) =>
            ParameterList(SingletonSeparatedList(parameter));

        public static type ToParameter(this KeyValuePair<string, string> @this) =>
            Parameter(Identifier(@this.Key)).WithType(ParseTypeName(@this.Value));

        public static type ToParameter(this (string identifier, string type) @this) =>
            Parameter(Identifier(@this.identifier)).WithType(ParseTypeName(@this.type));

        public static IEnumerable<ParameterSyntax> ToParameters(this IEnumerable<KeyValuePair<string, string>> @this) =>
            @this.Select(ToParameter);
    }
}
