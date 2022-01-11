using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = NamespaceDeclarationSyntax;

    public static class NamespaceDeclarationSyntaxExtensions
    {
        public static DeclarationSyntax AddUsing(this DeclarationSyntax @this, string usingDirectiveName) =>
            @this.AddUsings(UsingDirective(ParseName(usingDirectiveName)));

        public static DeclarationSyntax AddUsings(this DeclarationSyntax @this, params string[] usingDirectiveNames) =>
            @this.AddUsings(usingDirectiveNames.Select(udn => UsingDirective(ParseName(udn))).ToArray());
    }
}
