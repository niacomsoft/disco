// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    public static partial class Guard
    {
#if NET20 || NET30 || NET35 || NET40

        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> （ <see cref="string.IsNullOrEmpty(string)" />）时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> （ <see cref="string.IsNullOrEmpty(string)" />）时返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> （ <see cref="string.IsNullOrEmpty(string)" />）时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        public static string SafeGet(string s, string @default)
            => string.IsNullOrEmpty(s) ? @default : s;

#endif

#if NET45_OR_GREATER || NETCOREAPP || NETSTANDARD || NET

        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空白符（仅 <paramref name="includeWhitespace" /> 等于 <c> true </c>）时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空白符（仅 <paramref name="includeWhitespace" /> 等于 <c> true </c>）时返回的字符串。
        /// </param>
        /// <param name="includeWhitespace">
        ///     是否包含空白符验证。
        ///     <para> 当 <paramref name="includeWhitespace" /> 等于 <c> true </c> 时，使用 <see cref="string.IsNullOrWhiteSpace(string)" /> 验证；否则使用 <see cref="string.IsNullOrEmpty(string)" />。 </para>
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空白符（仅 <paramref name="includeWhitespace" /> 等于 <c> true </c>）时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
        public static string SafeGet(string s, string @default, bool includeWhitespace = true)
        {
            if (includeWhitespace)
            {
                return string.IsNullOrWhiteSpace(s) ? @default : s;
            }

            return string.IsNullOrEmpty(s) ? @default : s;
        }

#endif
    }
}