// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco
{
    using System;

    /// <summary>
    ///     提供了 <see cref="String" /> 相关的工具方法。
    /// </summary>
    public static class StringUtilities
    {
        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        public static string IfNullOrEmpty(string s, string @default) => string.IsNullOrEmpty(s) ? @default : s;

        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="default">
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c> 或 <see cref="string.Empty" /> 或空格符时，返回 <paramref name="default" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
        public static string IfNullOrWhitespace(string s, string @default) => string.IsNullOrWhiteSpace(s) ? @default : s;
    }
}