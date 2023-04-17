// Copyright © 2006 - 2023 Wang Yucai. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Niacomsoft.Disco
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Niacomsoft.Disco.Resources;

#if NET40_OR_GREATER || NETSTANDARD || NETCOREAPP || NET

    public static partial class StringExtensions
    {
        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换为可为空的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <returns>
        ///     当 <see cref="int.TryParse(string, out int)" /> 返回 <c> true </c> 时，返回 <see cref="int" /> 类型的值；否则返回 <c> null </c>。
        /// </returns>
        /// <seealso cref="TryParseToInt32(string, out int)" />
        public static int? AsInt32(this string s)
            => s.TryParseToInt32(out int value) ? value : (int?)null;

        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换成 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <returns>
        ///     <see cref="int" /> 类型的值。
        ///     <para> 可能引发 <see cref="InvalidCastException" /> 类型的异常。 </para>
        /// </returns>
        /// <seealso cref="int.Parse(string)" />
        /// <seealso cref="int.TryParse(string, out int)" />
        /// <exception cref="InvalidCastException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static int ParseToInt32(this string s)
        {
            return !s.TryParseToInt32(out int value)
                ? throw new InvalidCastException(SR.Format("InvalidCastException_default_message", null, nameof(String), nameof(Int32)))
                : value;
        }

        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换为 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <param name="value">
        ///     <see cref="int" /> 类型的值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，返回 <c> false </c>；否则返回 <see cref="int.TryParse(string, out int)" /> 的返回值。
        /// </returns>
        /// <seealso cref="int.TryParse(string, out int)" />
        public static bool TryParseToInt32(this string s, out int value)
        {
            value = int.MinValue;
            return !string.IsNullOrWhiteSpace(s) && int.TryParse(s, out value);
        }
    }

#endif
}