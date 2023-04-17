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
        ///     尝试将字符串 <paramref name="s" /> 转换为可为空的 <see cref="float" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <returns>
        ///     当 <see cref="float.TryParse(string, out float)" /> 返回 <c> true </c> 时，返回 <see cref="float" /> 类型的值；否则返回 <c> null </c>。
        /// </returns>
        /// <seealso cref="TryParseToSingle(string, out float)" />
        public static float? AsSingle(this string s)
            => s.TryParseToSingle(out float value) ? value : (float?)null;

        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换成 <see cref="float" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <returns>
        ///     <see cref="float" /> 类型的值。
        ///     <para> 可能引发 <see cref="InvalidCastException" /> 类型的异常。 </para>
        /// </returns>
        /// <seealso cref="float.Parse(string)" />
        /// <seealso cref="float.TryParse(string, out float)" />
        /// <exception cref="InvalidCastException">
        /// </exception>
        [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static float ParseToSingle(this string s)
        {
            return !s.TryParseToSingle(out float value)
                ? throw new InvalidCastException(SR.Format("InvalidCastException_default_message", null, nameof(String), nameof(Single)))
                : value;
        }

        /// <summary>
        ///     尝试将字符串 <paramref name="s" /> 转换为 <see cref="float" /> 类型的值。
        /// </summary>
        /// <param name="s">
        ///     数值字符串。
        /// </param>
        /// <param name="value">
        ///     <see cref="float" /> 类型的值。
        /// </param>
        /// <returns>
        ///     当 <paramref name="s" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，返回 <c> false </c>；否则返回 <see cref="float.TryParse(string, out float)" /> 的返回值。
        /// </returns>
        /// <seealso cref="float.TryParse(string, out float)" />
        public static bool TryParseToSingle(this string s, out float value)
        {
            value = float.MinValue;
            return !string.IsNullOrWhiteSpace(s) && float.TryParse(s, out value);
        }
    }

#endif
}