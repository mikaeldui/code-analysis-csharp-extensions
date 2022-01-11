using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    using static SyntaxFactory;

    public static class SyntaxKindExtensions
    {
        public static SyntaxToken ToToken(this SyntaxKind @this) => Token(@this);
        public static SyntaxTokenList ToTokenList(this SyntaxKind @this) => TokenList(Token(@this));

        // Arrays

        public static SyntaxToken[] ToTokens(this SyntaxKind[] @this) => @this.Select(Token).ToArray();
        public static SyntaxTokenList ToTokenList(this SyntaxKind[] @this) => TokenList(@this.Select(Token));
    }
}
