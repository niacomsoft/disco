// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
#if NET20 || NET30 || NET35
    using System.Text.RegularExpressions;
#endif

    /// <summary>
    ///     提供了字符串对比相关的方法。
    /// </summary>
    public static class StringEqualityComparer
    {
#if NET20 || NET30 || NET35
        /// <summary>
        ///     校验字符串 <paramref name="s" /> 是否全为空白符。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <returns>
        ///     如果字符串全部为空白符，则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        private static bool IsWhiteSpace(string s)
        {
            return string.IsNullOrEmpty(s) || Regex.IsMatch(s, @"^\s*$", RegexOptions.Multiline | RegexOptions.Singleline);
        }
#endif


#if NET20 || NET30 || NET35
        /// <summary>
        ///     用于对比字符串 <paramref name="s" /> 是否等于 <c> null </c>、 <see cref="string.Empty" /> 或空格符。
        /// </summary>
        /// <param name="s">
        ///     需要判断的字符串。
        /// </param>
        /// <param name="options">
        ///     <see cref="EmptyStringCompareOptions" /> 类型的值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空格符时，返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        /// <seealso cref="EmptyStringCompareOptions" />
        /// <seealso cref="ReferenceEqualityComparer"/>
        /// <seealso cref="string.IsNullOrEmpty(string)"/>
        /// <seealso cref="IsWhiteSpace(string)"/>
#else
        /// <summary>
        ///     用于对比字符串 <paramref name="s" /> 是否等于 <c> null </c>、 <see cref="string.Empty" /> 或空格符。
        /// </summary>
        /// <param name="s">
        ///     需要判断的字符串。
        /// </param>
        /// <param name="options">
        ///     <see cref="EmptyStringCompareOptions" /> 类型的值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或空格符时，返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        /// <seealso cref="EmptyStringCompareOptions" />
        /// <seealso cref="ReferenceEqualityComparer"/>
        /// <seealso cref="string.IsNullOrEmpty(string)"/>
        /// <seealso cref="string.IsNullOrWhiteSpace(string)"/>
#endif
        public static bool IsNullOrWhitespace(string s, EmptyStringCompareOptions options = EmptyStringCompareOptions.Default)
        {
            if (options == EmptyStringCompareOptions.OnlyNull) return ReferenceEqualityComparer.IsNull(s);
            else if (options == EmptyStringCompareOptions.NullOrEmpty) return string.IsNullOrEmpty(s);
            else
            {
#if NET20 || NET30 || NET35
                return IsWhiteSpace(s);
#else
                return string.IsNullOrWhiteSpace(s);
#endif
            }
        }
    }
}