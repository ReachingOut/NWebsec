// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.ComponentModel;
using NWebsec.Core.HttpHeaders.Configuration;

namespace NWebsec.Owin
{
    public class CspDirectiveUnsafeInline : CspDirective, ICspDirectiveUnsafeInlineConfiguration
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool UnsafeInlineSrc { get; set; }
    }
}