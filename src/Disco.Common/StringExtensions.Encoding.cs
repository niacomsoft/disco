// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    using Niacomsoft.Disco.Resources;

#if NET40_OR_GREATER || NETSTANDARD || NETCOREAPP || NET

    public static partial class StringExtensions
    {
        /// <summary>
        ///     使用编码 <paramref name="encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <param name="encoding">
        ///     指定的编码。
        /// </param>
        /// <returns>
        ///     字节数组。
        ///     <para> 当 <paramref name="s" /> 等于 <c> null </c> 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="ArgumentNullException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static byte[] GetBytes(this string s, Encoding encoding)
        {
            Guard.TrueThrow<ArgumentNullException>(ReferenceEqualityComparer.IsNull(encoding), nameof(encoding), SR.GetString("ArgumentNullException_null_encoding"));
            return ReferenceEqualityComparer.IsNull(s)
                ? null
                : encoding.GetBytes(s);
        }

        /// <summary>
        ///     使用 <see cref="UTF8Encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。
        /// </summary>
        /// <param name="s">
        ///     字符串。
        /// </param>
        /// <returns>
        ///     字节数组。
        ///     <para> 当 <paramref name="s" /> 等于 <c> null </c> 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="UTF8Encoding" />
        public static byte[] GetBytes(this string s)
            => s?.GetBytes(Encoding.UTF8);

        /// <summary>
        ///     使用编码 <paramref name="encoding" /> 获取字节数组 <paramref name="bytes" /> 的字符串。
        /// </summary>
        /// <param name="bytes">
        ///     字节数组。
        /// </param>
        /// <param name="encoding">
        ///     指定的程序。
        /// </param>
        /// <returns>
        ///     字符串。
        ///     <para> 当 <paramref name="bytes" /> 等于 <c> null </c> 或 <c> bytes.Length </c> 等于 0 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static string GetString(this byte[] bytes, Encoding encoding)
        {
            Guard.TrueThrow<ArgumentNullException>(ReferenceEqualityComparer.IsNull(encoding), nameof(encoding), SR.GetString("ArgumentNullException_null_encoding"));
            return ReferenceEqualityComparer.IsNull(bytes) || bytes.LongLength == 0
                ? null
                : encoding.GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     使用 <see cref="UTF8Encoding" /> 编码获取字节数组 <paramref name="bytes" /> 的字符串。
        /// </summary>
        /// <param name="bytes">
        ///     字节数组。
        /// </param>
        /// <returns>
        ///     字符串。
        ///     <para> 当 <paramref name="bytes" /> 等于 <c> null </c> 或 <c> bytes.Length </c> 等于 0 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="UTF8Encoding" />
        public static string GetString(this byte[] bytes)
            => bytes?.GetString(Encoding.UTF8);
    }

#endif
}