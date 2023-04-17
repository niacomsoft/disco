// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;

#if NET40_OR_GREATER || NETSTANDARD || NETCOREAPP || NET

    public static partial class StringExtensions
    {
        /// <summary>
        ///     从 BASE-64 字符串 <paramref name="base64Str" /> 获取字节数组。
        /// </summary>
        /// <param name="base64Str">
        ///     BASE-64 字符串。
        /// </param>
        /// <returns>
        ///     字节数组。
        ///     <para> 当 <paramref name="base64Str" /> 等于 <c> null </c> 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.FromBase64String(string)" />
        /// <exception cref="FormatException">
        /// </exception>
        public static byte[] FromBase64String(this string base64Str)
            => ReferenceEqualityComparer.IsNull(base64Str) ? null : Convert.FromBase64String(base64Str);

        /// <summary>
        ///     将字节数组 <paramref name="bytes" /> 转换成 BASE-64 字符串。
        /// </summary>
        /// <param name="bytes">
        ///     字节数组。
        /// </param>
        /// <param name="options">
        ///     <see cref="Base64FormattingOptions" /> 中的一个值。
        /// </param>
        /// <returns>
        ///     BASE-64 字节串。
        ///     <para> 当 <paramref name="bytes" /> 等于 <c> null </c> 或 <c> bytes.Length </c> 等于 0 时，返回 <c> null </c>。 </para>
        /// </returns>
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.ToBase64String(byte[], Base64FormattingOptions)" />
        /// <seealso cref="Base64FormattingOptions" />
        /// <seealso cref="Base64FormattingOptions.None" />
        public static string ToBase64String(this byte[] bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
            => ReferenceEqualityComparer.IsNull(bytes) || bytes.LongLength == 0 ? null : Convert.ToBase64String(bytes, options);
    }

#endif
}