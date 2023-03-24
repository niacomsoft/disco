// COPYRIGHT © 2023 WANG YUCAI. ALL RIGHTS RESERVED. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Niacomsoft.Disco.Utilities
{
    using System;

    /// <summary>
    ///     提供了字符串安全验证相关的方法。
    /// </summary>
    public static class StringGuard
    {
        /// <summary>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时（仅当 <paramref name="includeWhitespace" /> 等于 <c> true </c> 时），返回
        ///     <paramref name="safeString" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="safeString">
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时（仅当 <paramref name="includeWhitespace" /> 的返回值。
        /// </param>
        /// <param name="includeWhitespace">
        ///     是否使用 <see cref="string.IsNullOrWhiteSpace(string)" /> 验证 <paramref name="s" />。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时（仅当 <paramref name="includeWhitespace" /> 等于 <c> true </c> 时），返回
        ///     <paramref name="safeString" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
        public static string SafeGet(string s, string safeString, bool includeWhitespace = true)
        {
            if (includeWhitespace)
            {
                return string.IsNullOrWhiteSpace(s) ? safeString : s;
            }

            return string.IsNullOrEmpty(s) ? safeString : s;
        }

        /// <summary>
        ///     当 <paramref name="where" /> 返回 <c> true </c> 时，返回 <paramref name="safeString" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s">
        ///     需要校验的字符串。
        /// </param>
        /// <param name="where">
        ///     验证方法。( <see cref="Func{T, TResult}" />)
        /// </param>
        /// <param name="safeString">
        ///     当 <paramref name="where" /> 返回 <c> true </c> 时，需要返回的字符串。
        /// </param>
        /// <returns>
        ///     当 <paramref name="where" /> 返回 <c> true </c> 时，返回 <paramref name="safeString" />；否则返回 <paramref name="s" />。
        /// </returns>
        /// <seealso cref="Func{T, TResult}" />
        public static string SafeGet(string s, Func<string, bool> where, string safeString)
            => where(s) ? safeString : s;
    }
}