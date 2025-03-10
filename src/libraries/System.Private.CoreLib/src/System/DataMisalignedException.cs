// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=============================================================================
**
**
** Purpose: The exception class for a misaligned access exception
**
=============================================================================*/

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public sealed class DataMisalignedException : SystemException
    {
        public DataMisalignedException()
            : base(SR.Arg_DataMisalignedException)
        {
            HResult = HResults.COR_E_DATAMISALIGNED;
        }

        public DataMisalignedException(string? message)
            : base(message)
        {
            HResult = HResults.COR_E_DATAMISALIGNED;
        }

        public DataMisalignedException(string? message, Exception? innerException)
            : base(message, innerException)
        {
            HResult = HResults.COR_E_DATAMISALIGNED;
        }

        [Obsolete(Obsoletions.LegacyFormatterImplMessage, DiagnosticId = Obsoletions.LegacyFormatterImplDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private DataMisalignedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
