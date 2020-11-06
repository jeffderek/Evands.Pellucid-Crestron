﻿#region copyright
// <copyright file="TerminalCommandException.cs" company="Christopher McNeely">
// The MIT License (MIT)
// Copyright (c) Christopher McNeely
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
#endregion

using System;

namespace Elegant.Pellucid
{
    /// <summary>
    /// Exception class for wrapping exceptions that happen during the execution of terminal commands.
    /// <para>Can be used to wrap exceptions manually caught that still need to be passed up the chain as well.</para>
    /// </summary>
    public class TerminalCommandException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalCommandException"/> class.
        /// </summary>
        /// <param name="innerException">The inner exception this class wraps.</param>
        /// <param name="message">A message regarding the nature of the exception.</param>
        public TerminalCommandException(Exception innerException, string message)
            : base(message, innerException)
        {
        }
    }
}